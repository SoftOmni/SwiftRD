using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Parsing;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

using TypeIdentifierComponentBuilder =
    (List<ISwiftNode<SwiftCompositeNode>> children, Identifier identifier, IGenericArgumentClause? argumentClause);

public partial class SwiftParser
{
    private const string TypeIdentifierTypeKindIdentifier = "Type identifier type";

    private static partial class TypeParser
    {
        private static TypeIdentifier ProcessTypeIdentifier(SwiftLexer lexer, IEditableBuffer buffer, int currentOffset,
            List<ISwiftNode<SwiftCompositeNode>> children, Stack<TypeParserData> typesStack,
            ISwiftParsingSettings settings)
        {
            List<ITypeIdentifierComponent> components = [];
            List<Period> componentSeparators = [];

            SubEditableBuffer currentComponentBuffer = new(buffer, currentOffset);
            IEditableBuffer initialIdentifierBuffer = new SubEditableBuffer(buffer,
                currentOffset, lexer.TokenLength);
            Identifier initialIdentifier = new(initialIdentifierBuffer);

            TypeIdentifierComponentBuilder componentChildren =
                ([initialIdentifier], identifier: initialIdentifier, null);

            int startOfComponent = currentOffset;
            lexer.Advance();
            List<ISwiftNode<SwiftCompositeNode>> whitespaceAndCommentNodes = [];

            while (lexer.TokenType is not EndOfFileToken)
            {
                currentOffset = TypeIdentifierParserHelper.RegisterWhitespaceAfterRun(lexer, buffer, currentOffset,
                    settings, componentChildren, whitespaceAndCommentNodes, AdvanceAndAddCommentsWhitespace);


                if (lexer.TokenType is PeriodToken)
                {
                    TypeIdentifierParserHelper.DealWithPeriodEncounteredDuringLexing(lexer, buffer, currentOffset,
                        children, settings,
                        currentComponentBuffer, componentChildren, components, componentSeparators,
                        whitespaceAndCommentNodes);
                    break;
                }

                if (lexer.TokenType is LeftAngleBracketToken)
                {
                    (currentOffset, bool shouldStop, TypeParserData? genericArgumentStackTypeParserData) =
                        DealWithLeftAngleEncounteredDuringLexingInGenerics(
                            lexer, buffer, currentOffset, settings, currentComponentBuffer,
                            componentChildren, whitespaceAndCommentNodes, typesStack
                        );

                    if (shouldStop)
                    {
                        typesStack.Push(new TypeParserData(buffer, currentOffset, children, [],
                            TypeParserData.TypeKind.GetOrCreate(TypeIdentifierTypeKindIdentifier),
                            new TypeIdentifierData(componentChildren, components, componentSeparators,
                                currentComponentBuffer, whitespaceAndCommentNodes)));
                        
                        if (genericArgumentStackTypeParserData is not null)
                        {
                            typesStack.Push(genericArgumentStackTypeParserData.Value);
                        }
                    }

                    break;
                }

                //bool @continue = TypeIdentifierParserHelper.ProcessUnexpectedNode();
            }

            throw new System.NotImplementedException();
        }

        private static (int currentOffset, bool shouldStop, TypeParserData? genericArgumentStackTypeParserData)
            DealWithLeftAngleEncounteredDuringLexingInGenerics(SwiftLexer lexer, IEditableBuffer buffer,
                int currentOffset, ISwiftParsingSettings settings,
                SubEditableBuffer currentComponentBuffer, TypeIdentifierComponentBuilder componentChildren,
                List<ISwiftNode<SwiftCompositeNode>> whitespaceAndCommentNodes, Stack<TypeParserData> typesStack)
        {
            IEditableBuffer leftAngleBracketBuffer = new SubEditableBuffer(buffer, currentOffset, lexer.TokenLength);
            LeftAngleBracket leftAngleBracket = new(leftAngleBracketBuffer);

            (IGenericArgumentClause? genericArgumentClause, TypeParserData? genericArgumentStackTypeParserData) =
                ProcessGenericArgumentClause(lexer, buffer, currentOffset, leftAngleBracket,
                    [leftAngleBracket], typesStack, settings);
            if (genericArgumentClause is null) // Means the processing is not complete and that to avoid
                // recursion problems, we need to pause type identifier processing
            {
                return (currentOffset, true, genericArgumentStackTypeParserData);
            }

            currentComponentBuffer.SetLengthToParentOffset(currentOffset);
            componentChildren.argumentClause = genericArgumentClause;
            return (currentOffset, false, null);
        }
    }

    private struct TypeIdentifierData
    {
        internal TypeIdentifierComponentBuilder ComponentChildren { get; }

        internal List<ITypeIdentifierComponent> Components { get; }

        internal List<Period> ComponentSeparators { get; }

        internal SubEditableBuffer CurrentComponentBuffer { get; }

        internal List<ISwiftNode<SwiftCompositeNode>> WhitespaceAndCommentsNodes { get; }

        internal TypeIdentifierData(TypeIdentifierComponentBuilder componentChildren,
            List<ITypeIdentifierComponent> components, List<Period> componentSeparators,
            SubEditableBuffer currentComponentBuffer, List<ISwiftNode<SwiftCompositeNode>> whitespaceAndCommentsNodes)
        {
            ComponentChildren = componentChildren;
            Components = components;
            ComponentSeparators = componentSeparators;
            CurrentComponentBuffer = currentComponentBuffer;
            WhitespaceAndCommentsNodes = whitespaceAndCommentsNodes;
        }
    }
}

file static class TypeIdentifierParserHelper
{
    public static void DealWithPeriodEncounteredDuringLexing(SwiftLexer lexer, IEditableBuffer buffer,
        int currentOffset, List<ISwiftNode<SwiftCompositeNode>> children, ISwiftParsingSettings settings,
        SubEditableBuffer currentComponentBuffer, TypeIdentifierComponentBuilder componentChildren,
        List<ITypeIdentifierComponent> components, List<Period> componentSeparators,
        List<ISwiftNode<SwiftCompositeNode>> whitespaceAndCommentNodes)
    {
        RegisterNewComponent(lexer, buffer, currentOffset, children, currentComponentBuffer, componentChildren,
            components);
        RegisterPeriod(lexer, buffer, currentOffset, children, componentSeparators);

        if (settings.GetTrailingWhitespaceAfterElementPolicy is ISwiftParsingSettings
                .TrailingWhitespaceAfterElementPolicy.IncludeAsSiblingOfElement)
        {
            children.AddRange(whitespaceAndCommentNodes);
        }

        lexer.Advance();
    }

    private static void RegisterNewComponent(SwiftLexer lexer, IEditableBuffer buffer, int currentOffset,
        List<ISwiftNode<SwiftCompositeNode>> children, SubEditableBuffer currentComponentBuffer,
        TypeIdentifierComponentBuilder componentChildren, List<ITypeIdentifierComponent> components)
    {
        currentComponentBuffer.SetLengthToParentOffset(currentOffset);
        TypeIdentifierComponent component = new(currentComponentBuffer, componentChildren.children,
            componentChildren.identifier, componentChildren.argumentClause);

        components.Add(component);
        children.Add(component);
        currentComponentBuffer = new SubEditableBuffer(buffer, currentOffset + lexer.TokenLength);
        componentChildren.children = [];
        componentChildren.identifier = null!;
        componentChildren.argumentClause = null;
    }

    private static void RegisterPeriod(SwiftLexer lexer, IEditableBuffer buffer, int currentOffset,
        List<ISwiftNode<SwiftCompositeNode>> children, List<Period> componentSeparators)
    {
        IEditableBuffer periodBuffer = new SubEditableBuffer(buffer, currentOffset, lexer.TokenLength);
        Period period = new(periodBuffer);
        componentSeparators.Add(period);
        children.Add(period);
    }

    public static int RegisterWhitespaceAfterRun(SwiftLexer lexer, IEditableBuffer buffer, int currentOffset,
        ISwiftParsingSettings settings, TypeIdentifierComponentBuilder componentChildren,
        List<ISwiftNode<SwiftCompositeNode>> whitespaceAndCommentNodes,
        Func<IEditableBuffer, int, List<ISwiftNode<SwiftCompositeNode>>, SwiftLexer, int> whitespaceRegistrar)
    {
        if (settings.GetTrailingWhitespaceAfterElementPolicy is ISwiftParsingSettings
                .TrailingWhitespaceAfterElementPolicy.IncludeAsChildOfElement)
        {
            currentOffset = whitespaceRegistrar(buffer, currentOffset, componentChildren.children, lexer);
        }
        else if (settings.GetTrailingWhitespaceAfterElementPolicy is ISwiftParsingSettings
                     .TrailingWhitespaceAfterElementPolicy.IncludeAsSiblingOfElement)
        {
            whitespaceAndCommentNodes.Clear();
            currentOffset = whitespaceRegistrar(buffer, currentOffset, whitespaceAndCommentNodes, lexer);
        }

        return currentOffset;
    }

    public static void ProcessUnexpectedNode(IEditableBuffer buffer, List<ISwiftNode<SwiftCompositeNode>> children,
        ISwiftParsingSettings settings,
        int startOfIdentifier, int endOfIdentifier, List<ISwiftNode<SwiftCompositeNode>> componentChildren)
    {
        IEditableBuffer componentBuffer =
            new SubEditableBuffer(buffer, startOfIdentifier, endOfIdentifier - startOfIdentifier);

        IEditableBuffer identifierBuffer =
            new SubEditableBuffer(componentBuffer, 0, componentBuffer.Length);
        IIdentifier identifier = new Identifier(identifierBuffer);


        if (settings.GetTrailingWhitespaceAfterElementPolicy is ISwiftParsingSettings
                .TrailingWhitespaceAfterElementPolicy.IncludeAsSiblingOfElement)
        {
            componentChildren.Clear();
        }
        else
        {
            while (componentChildren.Count > 0 &&
                   componentChildren[componentChildren.Count - 1] is IWhitespaceNode whitespaceNode)
            {
                componentChildren.RemoveAt(componentChildren.Count - 1);
            }
        }

        componentChildren.Add(identifier);

        ITypeIdentifierComponent component =
            new TypeIdentifierComponent(componentBuffer, children, identifier);
    }
}