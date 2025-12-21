using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Marker;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Markers;

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