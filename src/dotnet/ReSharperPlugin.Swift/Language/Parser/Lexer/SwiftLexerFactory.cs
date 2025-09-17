using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer;

public class SwiftLexerFactory : ILexerFactory
{
    public ILexer CreateLexer(IBuffer buffer)
    {
        return new SwiftFilteringLexer(new SwiftLexer(buffer));
    }
}