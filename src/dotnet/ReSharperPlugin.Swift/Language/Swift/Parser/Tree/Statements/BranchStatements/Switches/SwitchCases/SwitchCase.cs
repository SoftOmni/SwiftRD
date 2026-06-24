using System.Collections.Generic;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases;

public abstract class SwitchCase : SwiftInternalNode
{
    public SwitchStatement? Switch { get; internal set; }

    protected SwitchCase(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected SwitchCase(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected SwitchCase(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    protected SwitchCase(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}