using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ThrowStatements;

public class ThrowStatement : SwiftCompositeNode, IThrowStatement
{
    public Throw Throw { get; }

    public IExpression Expression { get; }

    internal ThrowStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        Throw @throw, IExpression expression)
        : base(buffer, children)
    {
        Throw = @throw;
        Expression = expression;
    }

    IReadOnlyExpression IReadOnlyThrowStatement.Expression => Expression;

    public void ChangeExpression(IExpression expression)
    {
        throw new NotImplementedException();
    }
}
