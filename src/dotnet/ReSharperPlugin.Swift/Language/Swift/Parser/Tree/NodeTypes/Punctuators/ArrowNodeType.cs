using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Punctuators;

public class ArrowNodeType : PunctuatorNodeType
{
    internal ArrowNodeType()
        : base(SwiftTokens.ArrowId, SwiftTokens.ArrowIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return Arrow.Create();
    }
}