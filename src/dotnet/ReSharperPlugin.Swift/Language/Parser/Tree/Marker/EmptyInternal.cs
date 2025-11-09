using System.Collections.Generic;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Marker;

public abstract class EmptyInternal : SwiftInternalNode, IMarker
{
    protected EmptyInternal(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected EmptyInternal(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected EmptyInternal(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    protected EmptyInternal(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }


    public override NodeType NodeType => NodeTypes.NodeTypes.Empty;
}