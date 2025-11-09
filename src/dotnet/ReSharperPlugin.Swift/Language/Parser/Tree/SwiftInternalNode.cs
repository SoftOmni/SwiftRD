using System.Collections.Generic;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree;

public abstract class SwiftInternalNode : SwiftNode
{
    protected SwiftInternalNode(IEditableBuffer buffer, List<ISwiftNode> children) : base(buffer, children)
    { }

    protected SwiftInternalNode(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) : base(buffer, children)
    { }

    protected SwiftInternalNode(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }

    protected SwiftInternalNode(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }

    public override NodeType NodeType => NodeTypes.NodeTypes.InternalNode;
}