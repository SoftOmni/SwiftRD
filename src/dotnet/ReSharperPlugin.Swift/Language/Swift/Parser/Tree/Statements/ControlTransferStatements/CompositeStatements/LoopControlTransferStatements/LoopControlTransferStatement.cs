using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.LoopControlTransferStatements;

public abstract class LoopControlTransferStatement : ControlTransferStatementInternalNode
{
    public LoopStatement? LoopStatement { get; protected set; }

    public Identifier? LabelName { get; internal set; }

    protected LoopControlTransferStatement(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected LoopControlTransferStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected LoopControlTransferStatement(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    protected LoopControlTransferStatement(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public bool HasNoLoopStatement => LoopStatement is null;
    
    public bool HasLoopStatement => LoopStatement is not null;
}