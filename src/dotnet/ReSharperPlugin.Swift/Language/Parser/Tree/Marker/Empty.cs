using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Marker;

public class Empty : SwiftLeafNode, IMarker
{
    public Empty(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Empty)
    { }

    public Empty(ISwiftNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Empty)
    { }
}