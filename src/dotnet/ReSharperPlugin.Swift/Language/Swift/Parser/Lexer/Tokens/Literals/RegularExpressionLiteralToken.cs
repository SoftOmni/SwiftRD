using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class RegularExpressionLiteralToken() : SwiftLiteral(SwiftTokens.RegularExpressionLiteralId, SwiftTokens.RegularExpressionLiteralIndex)
{
    public override string TokenRepresentation => SwiftTokens.RegularExpressionLiteralId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}