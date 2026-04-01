using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements;

public abstract class BranchStatement : StatementInternalNode
{
    protected BranchStatement(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected BranchStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected BranchStatement(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    protected BranchStatement(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
    
    public abstract bool AllowsBreakStatements { get; }
}