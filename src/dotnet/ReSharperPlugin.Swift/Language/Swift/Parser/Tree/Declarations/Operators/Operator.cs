using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Operators;

public class Operator : SwiftLeafNode
{
    public Operator(IEditableBuffer buffer)
        : base(buffer, NodeTypes.NodeTypes.Operator)
    { }

    public Operator(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, NodeTypes.NodeTypes.Operator)
    { }
}