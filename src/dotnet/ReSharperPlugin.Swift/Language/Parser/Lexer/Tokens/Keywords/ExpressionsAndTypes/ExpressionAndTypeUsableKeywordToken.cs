using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Keywords;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.ExpressionsAndTypes;

public abstract class ExpressionAndTypeUsableKeywordToken(string value, int index) : SwiftKeywordToken(value, index)
{
    public override bool ExpressionAndTypeUsable => true;
}
