using System.Collections.Generic;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.ControlTransferStatements;

public abstract class ControlTransferStatementInternalNode : StatementInternalNode, IControlTransferStatement
{
    protected ControlTransferStatementInternalNode(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected ControlTransferStatementInternalNode(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }
    
    protected ControlTransferStatementInternalNode(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    protected ControlTransferStatementInternalNode(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}