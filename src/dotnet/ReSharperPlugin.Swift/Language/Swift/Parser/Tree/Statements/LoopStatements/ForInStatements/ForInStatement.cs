using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.ControlTransferStatements;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.ForInStatements;

public class ForInStatement : SwiftCompositeNode, IForInStatement
{
    public For For { get; }

    public Case? Case { get; }

    public IPattern Pattern { get; }

    public In In { get; }

    public IExpression? Expression { get; }

    public IWhereClause? WhereClause { get; }

    public ICodeBlock CodeBlock { get; }

    internal List<IControlTransferStatement> ControlTransferStatements { get; }

    internal ForInStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        For @for, Case? @case, IPattern pattern, In @in, IExpression? expression, IWhereClause? whereClause,
        ICodeBlock codeBlock)
        : base(buffer, children)
    {
        For = @for;
        Case = @case;
        Pattern = pattern;
        In = @in;
        Expression = expression;
        WhereClause = whereClause;
        CodeBlock = codeBlock;

        ControlTransferStatements = [];
    }

    IReadOnlyPattern IReadOnlyForInStatement.Pattern => Pattern;

    IReadOnlyExpression? IReadOnlyForInStatement.Expression => Expression;

    IReadOnlyWhereClause? IReadOnlyForInStatement.WhereClause => WhereClause;

    IReadOnlyCodeBlock IReadOnlyLoopStatement.CodeBlock => CodeBlock;

    public IReadOnlyList<IControlTransferStatement> LoopControlTransferStatements => ControlTransferStatements;

    IReadOnlyList<IReadOnlyControlTransferStatement> IReadOnlyLoopStatement.LoopControlTransferStatements =>
        LoopControlTransferStatements;

    public void ChangeCodeBlock(ICodeBlock newCodeBlock)
    {
        throw new NotImplementedException();
    }

    public void AddExplicitCase()
    {
        throw new NotImplementedException();
    }

    public void RemoveExplicitCase()
    {
        throw new NotImplementedException();
    }

    public void ChangePattern(IPattern newPattern)
    {
        throw new NotImplementedException();
    }

    public void SetExpressionTo(IExpression newExpression)
    {
        throw new NotImplementedException();
    }

    public void RemoveExpression()
    {
        throw new NotImplementedException();
    }

    public void SetWhereClause(IWhereClause newWhereClause)
    {
        throw new NotImplementedException();
    }

    public void RemoveWhereClause()
    {
        throw new NotImplementedException();
    }
}