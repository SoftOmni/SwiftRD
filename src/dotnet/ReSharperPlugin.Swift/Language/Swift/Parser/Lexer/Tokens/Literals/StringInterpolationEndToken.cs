using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class StringInterpolationEndToken()
    : SwiftTokenNodeType(SwiftTokens.StringInterpolationEndId, SwiftTokens.StringInterpolationEndIndex)
{
    public override string TokenRepresentation => SwiftTokens.StringInterpolationEndId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}