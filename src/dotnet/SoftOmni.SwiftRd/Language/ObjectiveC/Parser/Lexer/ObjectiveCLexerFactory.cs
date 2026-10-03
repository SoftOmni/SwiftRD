using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer;

public class ObjectiveCLexerFactory : ILexerFactory
{
    public ILexer CreateLexer(IBuffer buffer)
    {
        return new ObjectiveCFilteringLexer(new ObjectiveCLexer(buffer));
    }
}
