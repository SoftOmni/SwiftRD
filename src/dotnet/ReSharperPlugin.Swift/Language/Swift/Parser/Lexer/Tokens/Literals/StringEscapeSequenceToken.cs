using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Literals;

public class StringEscapeSequenceToken()
    : SwiftTokenNodeType(SwiftTokens.StringEscapeSequenceId, SwiftTokens.StringEscapeSequenceIndex)
{
    public override string TokenRepresentation => SwiftTokens.StringEscapeSequenceId;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }
}