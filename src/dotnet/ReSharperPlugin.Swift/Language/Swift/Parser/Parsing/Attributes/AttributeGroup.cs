using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Parsing;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static partial class AttributeParser
    {
        public static IAttributeGroup ParseAttributeGroupGivenStart(SwiftLexer lexer, ISwiftParsingSettings settings,
            IEditableBuffer buffer, int currentOffset, List<ISwiftNode<SwiftCompositeNode>> children)
        {
            SubEditableBuffer attributeGroupBuffer = new(buffer, currentOffset, lexer.TokenLength);

            int subOffset = 0;
            SubEditableBuffer attributeGroupStartBuffer = new(attributeGroupBuffer, subOffset, lexer.TokenLength);
            At at = new(attributeGroupStartBuffer);

            children.Add(at);

            subOffset += lexer.TokenLength;
            lexer.Advance();
            List<ISwiftNode<SwiftCompositeNode>> potentialWhitespaceNodes = [];

            if (IsAcceptedOpeningBraceForAttributeParsing(lexer, settings))
            {
                SubEditableBuffer emptyIdentifierBuffer = new(attributeGroupBuffer, subOffset);
                Identifier emptyIdentifier = new(emptyIdentifierBuffer);
                children.Add(at);
                children.Add(emptyIdentifier);
            }
            else if (IsInappropriateClosingBraceToleratedForAttributeParsing(lexer, settings))
            {
                SubEditableBuffer emptyIdentifierBuffer = new(attributeGroupBuffer, subOffset);
                Identifier emptyIdentifier = new(emptyIdentifierBuffer);
                children.Add(at);
                children.Add(emptyIdentifier);
                
                lexer.Advance();
                if 
            }
        }

        private static bool IsAcceptedOpeningBraceForAttributeParsing(SwiftLexer lexer,
            ISwiftParsingSettings parsingSettings)
        {
            bool acceptsNonStandardOpeningBraces =
                parsingSettings.GetAttributeParsingBracketsAcceptedVariantsPolicy is
                    ISwiftParsingSettings.AttributeParsingBracketsAcceptedVariants
                        .AcceptsBracketsAndBracesAndParenthesis;
            bool isNonStandardOpeningBrace = lexer.TokenType is LeftSquareBracketToken or LeftCurlyBraceToken;

            return lexer.TokenType is LeftParenthesisToken ||
                   acceptsNonStandardOpeningBraces && isNonStandardOpeningBrace;
        }

        private static bool IsInappropriateClosingBraceToleratedForAttributeParsing(SwiftLexer lexer,
            ISwiftParsingSettings parsingSettings)
        {
            bool isClosingParenthesis = lexer.TokenType is RightParenthesisToken;
            bool isClosingSquareBracket = lexer.TokenType is RightSquareBracketToken;
            bool isClosingCurlyBrace = lexer.TokenType is RightCurlyBraceToken;
            bool isExtraPunctuator = lexer.TokenType is AmpersandToken or
                AmpersandToken or ColonToken or CommaToken or EqualsToken or
                ExclamationMarkToken or HashToken or PeriodToken or QuestionMarkToken;
            bool isSemicolon = lexer.TokenType is SemicolonToken;

            bool acceptsClosingParenthesis = lexer.TokenType is RightParenthesisToken &&
                                             parsingSettings.GetAttributeParsingAcceptedMalformedEntryPointsPolicy
                                                 .AcceptsClosingParenthesis;

            bool acceptsClosingSquareBracket = lexer.TokenType is RightParenthesisToken &&
                                             parsingSettings.GetAttributeParsingAcceptedMalformedEntryPointsPolicy
                                                 .AcceptsClosingSquareBracket;

            bool acceptsClosingCurlyBrace = lexer.TokenType is RightParenthesisToken &&
                                             parsingSettings.GetAttributeParsingAcceptedMalformedEntryPointsPolicy
                                                 .AcceptsClosingCurlyBrace;

            bool acceptsExtraPunctuator = lexer.TokenType is RightParenthesisToken &&
                                             parsingSettings.GetAttributeParsingAcceptedMalformedEntryPointsPolicy
                                                 .AcceptsExtraPunctuators;

            bool acceptsSemicolon = lexer.TokenType is RightParenthesisToken &&
                                             parsingSettings.GetAttributeParsingAcceptedMalformedEntryPointsPolicy
                                                 .AcceptSemicolons;

            return isClosingParenthesis && acceptsClosingParenthesis ||
                   isClosingSquareBracket && acceptsClosingSquareBracket ||
                   isClosingCurlyBrace && acceptsClosingCurlyBrace ||
                   isExtraPunctuator && acceptsExtraPunctuator ||
                   isSemicolon && acceptsSemicolon;
        }
    }

    private static IAttributeGroup ParseAttributeGroupGivenStart(SwiftLexer lexer, ISwiftParsingSettings settings,
        IEditableBuffer buffer, int currentOffset, List<ISwiftNode<SwiftCompositeNode>> children)
    {
        return AttributeParser.ParseAttributeGroupGivenStart(lexer, settings, buffer, currentOffset, children);
    }
}