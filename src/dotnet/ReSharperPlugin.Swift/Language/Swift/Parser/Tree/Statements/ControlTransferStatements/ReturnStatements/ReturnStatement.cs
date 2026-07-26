using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements.ReturnStatements;

public class ReturnStatement : SwiftCompositeNode, IReturnStatement
{
    public Return Return { get; }

    public IExpression? ReturnExpression { get; }

    internal ReturnStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Return @return, IExpression? returnExpression)
        : base(buffer, children)
    {
        Return = @return;
        ReturnExpression = returnExpression;
    }

    IReadOnlyExpression? IReadOnlyReturnStatement.ReturnExpression => ReturnExpression;

    public void SetReturnExpressionTo(IExpression? expression)
    {
        throw new NotImplementedException();
    }

    public void RemoveReturnExpression()
    {
        throw new NotImplementedException();
    }
}
