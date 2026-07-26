using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using IReadOnlyOperator = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages.IReadOnlyOperator;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.ConditionalConditionComposing.LogicalNot;

public class NotCompilationCondition : SwiftCompositeNode, INotCompilationCondition
{
    public IReadOnlyOperator Operator { get; }
    
    public ICompilationCondition Operand { get; }

    internal NotCompilationCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        IReadOnlyOperator @operator, ICompilationCondition operand)
        : base(buffer, children)
    {
        Operator = @operator;
        Operand = operand;
    }

    IReadOnlyCompilationCondition IReadOnlyNotCompilationCondition.Operand => Operand;

    public bool Evaluatable()
    {
        throw new NotImplementedException();
    }

    public bool Evaluate()
    {
        throw new NotImplementedException();
    }

    public void ChangeOperand(ICompilationCondition newOperand)
    {
        throw new NotImplementedException();
    }
}
