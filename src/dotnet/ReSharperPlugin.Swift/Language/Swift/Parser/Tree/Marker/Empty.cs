using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Marker;

public class Empty : SwiftLeafNode, IMarker
{
    public Empty(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.Empty)
    { }

    public Empty(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.Empty)
    { }
}