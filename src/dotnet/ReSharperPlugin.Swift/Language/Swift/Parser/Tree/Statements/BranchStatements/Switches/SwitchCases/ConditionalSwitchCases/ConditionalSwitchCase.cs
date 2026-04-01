using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.SwitchCases.ConditionalSwitchCases;

public class ConditionalSwitchCase : SwiftInternalNode
{
    public If? If { get; internal set; }

    private List<CompilationCondition> _conditions = [];

    private List<(Else @else, If @if)> _elseIfs = [];

    private List<SwitchCaseGroup> _switchCases = [];
    
    public Else? Else { get; internal set; }

    public ConditionalSwitchCase(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ConditionalSwitchCase(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ConditionalSwitchCase(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ConditionalSwitchCase(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<CompilationCondition> Conditions => _conditions;

    public IReadOnlyList<(Else @else, If @if)> ElseIfs => _elseIfs;

    public IReadOnlyList<SwitchCaseGroup> SwitchCases => _switchCases;
}