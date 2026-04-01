using System;
using System.Collections.Generic;
using System.Text;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.ParserExceptions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Declarations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TypeAliases;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static class TypeAliasParser
    {
        public static ITypeAlias ParseTypeAliasGivenStart(SwiftLexer lexer, IEditableBuffer buffer, int currentOffset,
            List<ISwiftNode<SwiftCompositeNode>> children, AttributeGroup? attributeGroup, IAccessLevelModifier? accessLevelModifier)
        {
            // We assume the token we have just come across is that of the typealias keyword

            if (lexer.TokenType is not TypealiasKeywordToken)
            {
                throw new SyntaxError("Error: keywordless typealias");
            }

            TypeAliasKeyword keyword = new(new SubEditableBuffer(buffer, currentOffset, lexer.TokenLength));
            currentOffset += lexer.TokenLength;
            children.Add(keyword);

            currentOffset = AdvanceAndAddCommentsWhitespace(buffer, currentOffset, children, lexer);
            if (lexer.TokenType is EndOfFileToken)
            {
                return new IncompleteTypeAliasNode(buffer, children, attributeGroup, accessLevelModifier, keyword, null, null, null);
            }

            bool canBeReasonablyInterpretedAsType = TypeExtensions.CanBeReasonablyInterpretedAsType(lexer);
            if ((lexer.TokenType is not IdentifierToken && lexer.TokenType is not EqualsToken) || !canBeReasonablyInterpretedAsType)
            {
                return new IncompleteTypeAliasNode(buffer, children, attributeGroup, accessLevelModifier, keyword, null, null, null);
            }

            Identifier? identifier = null;
            Equal? equalNode = null;
            IType? type = null;
            if (lexer.TokenType is IdentifierToken)
            {
                identifier = new Identifier(new SubEditableBuffer(buffer, currentOffset, lexer.TokenLength));
                children.Add(identifier);
            }
            else if (lexer.TokenType is EqualsToken)
            {
                equalNode = new Equal(new SubEditableBuffer(buffer, currentOffset, lexer.TokenLength));
                children.Add(equalNode);
            }
            else if (canBeReasonablyInterpretedAsType)
            {
                type = ParseType(lexer);
                children.Add(type);
                
                return new IncompleteTypeAliasNode(buffer, children, attributeGroup, accessLevelModifier, keyword, identifier, equalNode, type);
            }
            else
            {
                UnexpectedParserStateException exception = TypeAliasUnexpectedParserStatesExtensions.GenerateUnexpectedParserStateException(
                    TypeAliasUnexpectedParserStates.IdentifierEqualsOrTypeExpectedToBeValidAtThisPointBeforeSettingUpCorrespondingNode);
                throw exception;
            }

            currentOffset += lexer.TokenLength;            
            currentOffset = AdvanceAndAddCommentsWhitespace(buffer, currentOffset, children, lexer);

            if (lexer.TokenType is EndOfFileToken)
            {
                return new IncompleteTypeAliasNode(buffer, children, attributeGroup, accessLevelModifier, keyword, identifier, equalNode, type);
            }

            if (type is not null)
            {
                UnexpectedParserStateException exception = TypeAliasUnexpectedParserStatesExtensions.GenerateUnexpectedParserStateException(
                    TypeAliasUnexpectedParserStates.TypeExpectedToBeNullAfterFirstElementAfterKeywordConsumed);
                throw exception;
            }

            if (identifier is null && equalNode is null)
            {
                UnexpectedParserStateException exception = TypeAliasUnexpectedParserStatesExtensions.GenerateUnexpectedParserStateException(
                    TypeAliasUnexpectedParserStates.IdentifierOrEqualsExpectedToNotBeNullAfterFirstElementAfterKeywordConsumed);
                throw exception;
            }

            if (equalNode is null)
            {
                return ParseWithKeywordAndName(lexer, currentOffset, buffer, children, attributeGroup, accessLevelModifier, keyword, identifier);
            }

            return ParseWithEqualSignInHand(lexer, currentOffset, buffer, children, attributeGroup, accessLevelModifier, keyword, identifier, equalNode);
        }

        private static ITypeAlias ParseWithKeywordAndName(SwiftLexer lexer, int currentOffset, IEditableBuffer buffer,
            List<ISwiftNode<SwiftCompositeNode>> children, AttributeGroup? attributeGroup, IAccessLevelModifier? accessLevelModifier,
            TypeAliasKeyword keyword, Identifier? identifier)
        {
            bool canBeReasonablyInterpretedAsType = TypeExtensions.CanBeReasonablyInterpretedAsType(lexer);
            if (lexer.TokenType is not EqualsToken || !canBeReasonablyInterpretedAsType)
            {
                return new IncompleteTypeAliasNode(buffer, children, attributeGroup, accessLevelModifier, keyword, identifier, null, null);
            }

            Equal? equal;
            if (canBeReasonablyInterpretedAsType)
            {
                IType type = ParseType();
                children.Add(type);
                
                return new IncompleteTypeAliasNode(buffer, children, attributeGroup, accessLevelModifier, keyword, identifier, null, type);
            }
            else if (lexer.TokenType is EqualsToken)
            {
                equal = new Equal(new SubEditableBuffer(buffer, currentOffset, lexer.TokenLength));
            }
            else
            {
                UnexpectedParserStateException exception =
                    TypeAliasUnexpectedParserStatesExtensions.GenerateUnexpectedParserStateException(TypeAliasUnexpectedParserStates
                        .EqualsOrTypeExpectedToBeValidAtThisPointBeforeSettingUpCorrespondingNode);
                throw exception;
            }
            
            currentOffset += lexer.TokenLength;
            children.Add(equal);
            currentOffset = AdvanceAndAddCommentsWhitespace(buffer, currentOffset, children, lexer);

            if (lexer.TokenType is EndOfFileToken)
            {
                return new IncompleteTypeAliasNode(buffer, children, attributeGroup, accessLevelModifier, keyword, identifier, equalNode, type);
            }

            return ParseWithEqualSignInHand(lexer, currentOffset, buffer, children, attributeGroup, accessLevelModifier, keyword, identifier, equal);
        }

        private static ITypeAlias ParseWithEqualSignInHand(SwiftLexer lexer, int currentOffset, IEditableBuffer buffer,
            List<ISwiftNode<SwiftCompositeNode>> children, AttributeGroup? attributeGroup, IAccessLevelModifier? accessLevelModifier,
            TypeAliasKeyword keyword, Identifier? identifier, Equal? equalsNode)
        {
            bool canBeReasonablyInterpretedAsType = TypeExtensions.CanBeReasonablyInterpretedAsType(lexer);
            if (!canBeReasonablyInterpretedAsType)
            {
                return new IncompleteTypeAliasNode(buffer, children, attributeGroup, accessLevelModifier, keyword, identifier, null, null);
            }

            IType type = ParseType();
            children.Add(type);

            lexer.Advance();

            if (identifier is not null && equalsNode is not null)
            {
                return new TypeAlias(buffer, children, attributeGroup, accessLevelModifier, keyword, identifier, equalsNode, type);
            }

            return new IncompleteTypeAliasNode(buffer, children, attributeGroup, accessLevelModifier, keyword, identifier, null, null);
        }
    }

    private ITypeAlias ParseTypeAliasGivenStart(SwiftLexer lexer, IEditableBuffer buffer, int currentOffset,
        List<ISwiftNode<SwiftCompositeNode>> children, AttributeGroup? attributeGroup, IAccessLevelModifier? accessLevelModifier)
    {
        return TypeAliasParser.ParseTypeAliasGivenStart(lexer, buffer, currentOffset, children, attributeGroup, accessLevelModifier);
    }

    public static ITypeAlias ParseTypeAlias(StringBuilder value)
    {
        throw new NotImplementedException();
    }

    public static ITypeAlias ParseTypeAlias(StringBuilder value, int start)
    {
        throw new NotImplementedException();
    }

    public static ITypeAlias ParseTypeAlias(StringBuilder value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public static ITypeAlias ParseTypeAlias(string value)
    {
        throw new NotImplementedException();
    }

    public static ITypeAlias ParseTypeAlias(string value, int start)
    {
        throw new NotImplementedException();
    }

    public static ITypeAlias ParseTypeAlias(string value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public static ITypeAlias ParseTypeAlias(IBuffer value)
    {
        throw new NotImplementedException();
    }

    public static ITypeAlias ParseTypeAlias(IBuffer value, int start)
    {
        throw new NotImplementedException();
    }

    public static ITypeAlias ParseTypeAlias(IBuffer value, int start, int count)
    {
        throw new NotImplementedException();
    }

    public static ITypeAlias ParseTypeAlias(ReadOnlySpan<char> value)
    {
        throw new NotImplementedException();
    }

    public static ITypeAlias ParseTypeAlias(ReadOnlySpan<char> value, int start)
    {
        throw new NotImplementedException();
    }

    public static ITypeAlias ParseTypeAlias(ReadOnlySpan<char> value, int start, int count)
    {
        throw new NotImplementedException();
    }
}

public enum TypeAliasUnexpectedParserStates
{
    IdentifierEqualsOrTypeExpectedToBeValidAtThisPointBeforeSettingUpCorrespondingNode,
    TypeExpectedToBeNullAfterFirstElementAfterKeywordConsumed,
    IdentifierOrEqualsExpectedToNotBeNullAfterFirstElementAfterKeywordConsumed,
    EqualsOrTypeExpectedToBeValidAtThisPointBeforeSettingUpCorrespondingNode
}

public static class TypeAliasUnexpectedParserStatesExtensions
{
    public static string GenerateUnexpectedParserStateStateKindString(TypeAliasUnexpectedParserStates unexpectedTypeAliasParserState)
    {
        return unexpectedTypeAliasParserState switch
        {
            TypeAliasUnexpectedParserStates.IdentifierEqualsOrTypeExpectedToBeValidAtThisPointBeforeSettingUpCorrespondingNode => "TODO",
            TypeAliasUnexpectedParserStates.TypeExpectedToBeNullAfterFirstElementAfterKeywordConsumed => "TODO",
            TypeAliasUnexpectedParserStates.IdentifierOrEqualsExpectedToNotBeNullAfterFirstElementAfterKeywordConsumed => "TODO",
            TypeAliasUnexpectedParserStates.EqualsOrTypeExpectedToBeValidAtThisPointBeforeSettingUpCorrespondingNode => "TODO",
            _ => throw new ArgumentOutOfRangeException(nameof(unexpectedTypeAliasParserState), unexpectedTypeAliasParserState, null)
        };
    }

    public static string GenerateUnexpectedParserStateStateKindMessage(TypeAliasUnexpectedParserStates unexpectedTypeAliasParserState)
    {
        return unexpectedTypeAliasParserState switch
        {
            TypeAliasUnexpectedParserStates.IdentifierEqualsOrTypeExpectedToBeValidAtThisPointBeforeSettingUpCorrespondingNode => "TODO",
            TypeAliasUnexpectedParserStates.TypeExpectedToBeNullAfterFirstElementAfterKeywordConsumed => "TODO",
            TypeAliasUnexpectedParserStates.IdentifierOrEqualsExpectedToNotBeNullAfterFirstElementAfterKeywordConsumed => "TODO",
            TypeAliasUnexpectedParserStates.EqualsOrTypeExpectedToBeValidAtThisPointBeforeSettingUpCorrespondingNode => "TODO",
            _ => throw new ArgumentOutOfRangeException(nameof(unexpectedTypeAliasParserState), unexpectedTypeAliasParserState, null)
        };
    }

    public static UnexpectedParserStateException GenerateUnexpectedParserStateException(
        TypeAliasUnexpectedParserStates unexpectedTypeAliasParserState)
    {
        return new UnexpectedParserStateException(GenerateUnexpectedParserStateStateKindMessage(unexpectedTypeAliasParserState),
            GenerateUnexpectedParserStateStateKindString(unexpectedTypeAliasParserState), (int)unexpectedTypeAliasParserState);
    }
}