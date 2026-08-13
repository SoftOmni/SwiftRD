using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class StringInterpolationStartToken() : SwiftTokenNodeType(SwiftTokens.StringInterpolationStartId,
    SwiftTokens.StringInterpolationStartIndex)
{
    public override string TokenRepresentation => SwiftTokens.StringInterpolationStartId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}