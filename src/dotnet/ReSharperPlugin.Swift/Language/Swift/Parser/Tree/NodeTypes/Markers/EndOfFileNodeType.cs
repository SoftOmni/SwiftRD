using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Marker;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Markers;

public class EndOfFileNodeType : MarkerNodeType
{
    internal EndOfFileNodeType()
        : base(SwiftTokens.EndOfFileId, SwiftTokens.EndOfFileIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return new EndOfFile(buffer);
    }
}