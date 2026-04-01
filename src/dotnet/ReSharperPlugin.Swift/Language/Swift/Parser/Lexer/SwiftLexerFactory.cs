using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;

public class SwiftLexerFactory : ILexerFactory
{
    public ILexer CreateLexer(IBuffer buffer)
    {
        return new SwiftFilteringLexer(new SwiftLexer(buffer));
    }
}