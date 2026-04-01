using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions;

public class OrCompilationCondition : CompilationCondition
{
    public CompilationCondition? LeftOperand { get; internal set; }
    
    public Operator OrOperator { get; internal set; }

    public CompilationCondition? RightOperand { get; internal set; }
    
    internal OrCompilationCondition(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    internal OrCompilationCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    internal OrCompilationCondition(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    internal OrCompilationCondition(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public override bool Evaluatable()
    {
        return (LeftOperand?.Evaluatable() ?? false)
               && (RightOperand?.Evaluatable() ?? false);
    }

    public override bool Evaluate()
    {
        if (LeftOperand is null || RightOperand is null)
        {
            return false;
        }

        return LeftOperand.Evaluate() || RightOperand.Evaluate();
    }
}