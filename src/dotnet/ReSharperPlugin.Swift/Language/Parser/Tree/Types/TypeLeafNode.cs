using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types;

public abstract class TypeLeafNode : SwiftLeafNode, IType
{
    protected TypeLeafNode(IEditableBuffer buffer, NodeType nodeType) 
        : base(buffer, nodeType)
    { }

    protected TypeLeafNode(ISwiftNode parent, IEditableBuffer buffer, NodeType nodeType) 
        : base(parent, buffer, nodeType)
    { }
}