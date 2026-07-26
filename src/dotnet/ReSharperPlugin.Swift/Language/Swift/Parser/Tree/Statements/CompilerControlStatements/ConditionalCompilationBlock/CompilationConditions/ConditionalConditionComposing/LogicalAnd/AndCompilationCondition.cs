using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using IReadOnlyOperator = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages.IReadOnlyOperator;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.ConditionalConditionComposing.LogicalAnd;

public class AndCompilationCondition : SwiftCompositeNode, IAndCompilationCondition
{
    public ICompilationCondition LeftOperand { get; }
    
    public IReadOnlyOperator Operator { get; }

    public ICompilationCondition RightOperand { get; }

    internal AndCompilationCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, ICompilationCondition leftOperand, IReadOnlyOperator @operator, ICompilationCondition rightOperand)
        : base(buffer, children)
    {
        LeftOperand = leftOperand;
        Operator = @operator;
        RightOperand = rightOperand;
    }

    IReadOnlyCompilationCondition IReadOnlyAndCompilationCondition.LeftOperand => LeftOperand;

    IReadOnlyCompilationCondition IReadOnlyAndCompilationCondition.RightOperand => RightOperand;

    public bool Evaluatable()
    {
        throw new NotImplementedException();
    }

    public bool Evaluate()
    {
        throw new NotImplementedException();
    }

    public void ChangeLeftOperand(ICompilationCondition newLeftOperand)
    {
        throw new NotImplementedException();
    }

    public void ChangeRightOperand(ICompilationCondition newRightOperand)
    {
        throw new NotImplementedException();
    }
}
