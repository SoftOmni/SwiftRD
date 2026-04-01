using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements;

public abstract class ControlTransferStatementLeafNode : StatementLeafNode, IControlTransferStatement
{
    protected ControlTransferStatementLeafNode(IEditableBuffer buffer, NodeType nodeType) 
        : base(buffer, nodeType)
    { }

    protected ControlTransferStatementLeafNode(SwiftInternalNode parent, IEditableBuffer buffer, NodeType nodeType) 
        : base(parent, buffer, nodeType)
    { }
}