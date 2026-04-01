using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

public abstract class TypeLeafNode : SwiftLeafNode, IType
{
    protected TypeLeafNode(IEditableBuffer buffer, NodeType nodeType) 
        : base(buffer, nodeType)
    { }

    protected TypeLeafNode(SwiftInternalNode parent, IEditableBuffer buffer, NodeType nodeType) 
        : base(parent, buffer, nodeType)
    { }
}