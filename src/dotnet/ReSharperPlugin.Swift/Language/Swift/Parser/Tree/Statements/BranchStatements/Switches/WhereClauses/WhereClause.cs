using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.GenericWhereClauseClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.WhereClauses;

public class WhereClause : SwiftCompositeNode, IWhereClause
{
    public Where Where { get; }

    public IExpression Expression { get; }

    internal WhereClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, Where where, IExpression expression)
        : base(buffer, children)
    {
        Where = where;
        Expression = expression;
    }

    IReadOnlyExpression IReadOnlyWhereClause.Expression => Expression;

    public void ChangeExpression(IExpression newExpression)
    {
        throw new NotImplementedException();
    }
}
