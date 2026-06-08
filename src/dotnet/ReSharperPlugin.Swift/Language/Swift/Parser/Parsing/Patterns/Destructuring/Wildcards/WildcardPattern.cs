using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.Wildcards;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser;

public partial class SwiftParser
{
    private static class WildcardParser
    {
        public static IWildcardPattern ParseWildcardPatternWithStart(SwiftLexer lexer, IEditableBuffer buffer,
            int currentOffset,
            List<ISwiftNode<SwiftCompositeNode>> children, Underscore underscore)
        {
            currentOffset = AdvanceAndAddCommentsWhitespace(buffer, currentOffset, children, lexer);
            if (lexer.TokenType is EndOfFileToken)
            {
                return new WildcardPattern(buffer, children, underscore);
            }

            if (TryToEatTypeAnnotation(buffer, currentOffset, lexer, out TypeAnnotation typeAnnotation))
            {
                return new WildcardPattern(buffer, children, underscore, typeAnnotation);
            }

            return new WildcardPattern(buffer, children, underscore);
        }    
    }
    
    private static IWildcardPattern ParseWildcardPatternWithStart(SwiftLexer lexer, IEditableBuffer buffer,
        int currentOffset,
        List<ISwiftNode<SwiftCompositeNode>> children, Underscore underscore)
    {
        return WildcardParser.ParseWildcardPatternWithStart(lexer, buffer, currentOffset, children, underscore);
    }

    public static IWildcardPattern ParseWildcardPattern(string code)
    {
        throw new NotImplementedException();
    }

    public static IWildcardPattern ParseWildcardPattern(ReadOnlySpan<char> code)
    {
        throw new NotImplementedException();
    }
}