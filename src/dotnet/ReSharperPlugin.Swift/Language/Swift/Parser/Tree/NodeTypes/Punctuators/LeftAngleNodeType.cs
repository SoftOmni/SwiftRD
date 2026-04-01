using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Punctuators;

public class LeftAngleNodeType : PunctuatorNodeType
{
    internal LeftAngleNodeType()
        : base(SwiftTokens.LeftAngleBracketId, SwiftTokens.LeftAngleBracketIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return LeftAngleBracket.Create();
    }
}