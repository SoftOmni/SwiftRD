using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Marker;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Markers;

public class StartOfFileNodeType : MarkerNodeType
{
    internal StartOfFileNodeType() 
        : base(SwiftTokens.StartOfFileId, SwiftTokens.StartOfFileIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return new StartOfFile(buffer);
    }
}