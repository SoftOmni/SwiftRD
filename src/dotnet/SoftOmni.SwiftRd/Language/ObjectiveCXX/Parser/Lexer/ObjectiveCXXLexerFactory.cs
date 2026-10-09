using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer;

public class ObjectiveCXXLexerFactory : ILexerFactory
{
    public ILexer CreateLexer(IBuffer buffer)
    {
        return new ObjectiveCXXFilteringLexer(new ObjectiveCXXLexer(buffer));
    }
}
