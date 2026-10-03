using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer;

public class ObjectiveCxxLexerFactory : ILexerFactory
{
    public ILexer CreateLexer(IBuffer buffer)
    {
        return new ObjectiveCxxFilteringLexer(new ObjectiveCxxLexer(buffer));
    }
}
