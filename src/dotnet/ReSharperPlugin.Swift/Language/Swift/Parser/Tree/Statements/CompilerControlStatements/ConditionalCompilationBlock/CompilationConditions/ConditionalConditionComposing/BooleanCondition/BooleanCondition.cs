using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.ConditionalConditionComposing.BooleanCondition;

public class BooleanCondition : SwiftCompositeNode, IBooleanCondition
{
    public IBooleanLiteral BooleanLiteral { get; }

    internal BooleanCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        IBooleanLiteral booleanLiteral)
        : base(buffer, children)
    {
        BooleanLiteral = booleanLiteral;
    }

    IReadOnlyBooleanLiteral IReadOnlyBooleanCondition.BooleanLiteral => BooleanLiteral;

    public bool Evaluatable()
    {
        throw new NotImplementedException();
    }

    public bool Evaluate()
    {
        throw new NotImplementedException();
    }

    public void Invert()
    {
        throw new NotImplementedException();
    }

    public void MakeTrue()
    {
        throw new NotImplementedException();
    }

    public void MakeFalse()
    {
        throw new NotImplementedException();
    }

    public void ChangeBooleanLiteral(IBooleanLiteral newBooleanLiteral)
    {
        throw new NotImplementedException();
    }
}
