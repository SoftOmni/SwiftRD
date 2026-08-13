using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ContextSensitive;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.ExpressionsAndTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Operators.BuiltinOperators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Parsing;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static partial class TypeParser
    {
        private struct TypeParserData
        {
            public struct TypeKind
            {
                private static readonly Dictionary<string, TypeKind> TypeKinds = [];

                public string Name { get; }

                public TypeKind(string name)
                {
                    if (TypeKinds.ContainsKey(name))
                    {
                        throw new ArgumentException(nameof(name), $"The type kind of value {name} " +
                                                                  $"has already been assigned to the type name whose name is {name}");
                    }

                    TypeKinds.Add(name, this);
                    Name = name;
                }

                public static TypeKind GetOrCreate(string name)
                {
                    if (TypeKinds.TryGetValue(name, out TypeKind typeKind))
                    {
                        return typeKind;
                    }

                    lock (TypeKinds)
                    {
                        typeKind = new TypeKind(name);
                    }

                    return typeKind;
                }
            }

            public IEditableBuffer Buffer { get; }

            public int CurrentOffset { get; }

            public List<ISwiftNode<SwiftCompositeNode>> Children { get; }

            public List<(ISwiftNode<SwiftCompositeNode> node, int significantPositioning)> SignificantChildren { get; }


            public IType? Type { get; private set; }

            public TypeKind Kind { get; }
            
            public TypeIdentifierData? TypeIdentifierExtraData { get; }

            public TypeParserData(IEditableBuffer buffer, int currentOffset,
                List<ISwiftNode<SwiftCompositeNode>> children,
                List<(ISwiftNode<SwiftCompositeNode> node, int significantPositioning)> significantChildren,
                TypeKind kind, IType type, TypeIdentifierData? typeIdentifierExtraData = null)
            {
                Buffer = buffer;
                CurrentOffset = currentOffset;
                Children = children;
                SignificantChildren = significantChildren;
                Kind = kind;
                Type = type;
                TypeIdentifierExtraData = typeIdentifierExtraData;
            }

            public TypeParserData(IEditableBuffer buffer, int currentOffset,
                List<ISwiftNode<SwiftCompositeNode>> children,
                List<(ISwiftNode<SwiftCompositeNode> node, int significantPositioning)> significantChildren,
                TypeKind kind, TypeIdentifierData? typeIdentifierExtraData = null)
            {
                Buffer = buffer;
                CurrentOffset = currentOffset;
                Children = children;
                SignificantChildren = significantChildren;
                Kind = kind;
                TypeIdentifierExtraData = typeIdentifierExtraData;
                Type = null;
            }

            public void SetType(IType type)
            {
                Type = type;
            }
        }

        public static IType ParseType(SwiftLexer lexer, ISwiftParsingSettings settings,
            IEditableBuffer buffer, int currentOffset, List<ISwiftNode<SwiftCompositeNode>> children)
        {
            currentOffset = AdvanceAndAddCommentsWhitespace(buffer, currentOffset, children, lexer);

            Stack<TypeParserData> typesStack = [];

            do
            {
                ProcessTypeToken(lexer, settings, buffer, currentOffset, children, typesStack);
            } while (typesStack.Count > 1 && lexer.TokenType is not EndOfFileToken);

            if (typesStack.Count > 1 && lexer.TokenType is EndOfFileToken)
            {
                return UnwindErroneousTypeStack(typesStack);
            }
        }

        private static void ProcessTypeToken(SwiftLexer lexer, ISwiftParsingSettings settings, IEditableBuffer buffer,
            int currentOffset, List<ISwiftNode<SwiftCompositeNode>> children, Stack<TypeParserData> typesStack)
        {
            switch (lexer.TokenType)
            {
                case AtToken:
                    ParseAttributeGroupGivenStart(lexer, settings, buffer, currentOffset, children);
                    break;
                case LeftParenthesisToken:
                    ProcessParenthesizedOrFunctionTypeOrTuple(buffer, currentOffset, children, typesStack);
                    break;
                case IdentifierToken:
                    ProcessTypeIdentifier(lexer, buffer, currentOffset, children, typesStack,
                        settings);
                    break;
                case LeftSquareBracketToken:
                    ProcessArrayOrDictionaryType(buffer, currentOffset, children, typesStack);
                    break;
                case SomeKeywordToken:
                    ProcessOpaqueType(buffer, currentOffset, children, typesStack);
                    break;
                case AnyLowercaseKeywordToken:
                    ProcessBoxedProtocolType(buffer, currentOffset, children, typesStack);
                    break;
                case AnyUppercaseKeywordToken:
                    ProcessAnyType(buffer, currentOffset, children, typesStack);
                    break;
                case SelfUppercaseKeywordToken:
                    ProcessSelfType(buffer, currentOffset, children, typesStack);
                    break;
                case PeriodToken:
                    break;
                case QuestionMarkPrefixOperatorToken:
                    break;
                case ExclamationMarkPrefixOperatorToken:
                    break;
            }
        }

        private static void ProcessArrayOrDictionaryType(IEditableBuffer buffer, int currentOffset,
            List<ISwiftNode<SwiftCompositeNode>> children, Stack<TypeParserData> typesStack)
        { }

        private static void ProcessParenthesizedOrFunctionTypeOrTuple(
            IEditableBuffer buffer, int currentOffset,
            List<ISwiftNode<SwiftCompositeNode>> children,
            Stack<TypeParserData> typesStack)
        {
            
        }
    }

    private static IType ParseType(SwiftLexer lexer, ISwiftParsingSettings settings,
        IEditableBuffer buffer, int currentOffset, List<ISwiftNode<SwiftCompositeNode>> children)
    {
        return TypeParser.ParseType(lexer, settings, buffer, currentOffset, children);
    }
}