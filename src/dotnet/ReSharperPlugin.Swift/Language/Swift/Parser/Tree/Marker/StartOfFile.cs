using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Marker;

public class StartOfFile : SwiftLeafNode, IMarker
{
    public StartOfFile(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.StartOfFile)
    { }

    public StartOfFile(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.StartOfFile)
    { }
}