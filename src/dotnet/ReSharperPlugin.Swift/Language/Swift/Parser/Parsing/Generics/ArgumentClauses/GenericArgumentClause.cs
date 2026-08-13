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
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static class GenericArgumentClauseParser
    {
        public static IGenericArgumentClause ParseGenericArgumentClauseWithStart(SwiftLexer lexer,
            IEditableBuffer buffer, ref int currentOffset,
            List<ISwiftNode<SwiftCompositeNode>> children, LeftAngleBracket? leftAngleBracket,
            ISwiftParsingSettings parsingSettings)
        {
            currentOffset = AdvanceAndAddCommentsWhitespace(buffer, currentOffset, children, lexer);
            if (lexer.TokenType is EndOfFileToken)
            {
                return new IncompleteGenericArgumentClause(buffer, "Missing closing > with generic arguments",
                    leftAngleBracket);
            }

            if (lexer.TokenType is RightAngleBracketToken)
            {
                RightAngleBracket rightAngleBracket =
                    new(new SubEditableBuffer(buffer, currentOffset, lexer.TokenLength));
                return new IncompleteGenericArgumentClause(buffer, "Missing generic arguments", leftAngleBracket,
                    rightAngleBracket: rightAngleBracket);
            }

            throw new NotImplementedException();
        }

    }

    private static IGenericArgumentClause ParseGenericArgumentClauseWithStart(SwiftLexer lexer, IEditableBuffer buffer,
        ref int currentOffset,
        List<ISwiftNode<SwiftCompositeNode>> children, LeftAngleBracket? leftAngleBracket, ISwiftParsingSettings swiftParsingSettings)
    {
        return GenericArgumentClauseParser.ParseGenericArgumentClauseWithStart(lexer, buffer, ref currentOffset, children, leftAngleBracket, swiftParsingSettings);
    }

    public static IGenericArgumentClause ParseGenericArgumentClause(string code)
    {
        throw new NotImplementedException();
    }

    public static IGenericArgumentClause ParseGenericArgumentClause(ReadOnlySpan<char> code)
    {
        throw new NotImplementedException();
    }
}