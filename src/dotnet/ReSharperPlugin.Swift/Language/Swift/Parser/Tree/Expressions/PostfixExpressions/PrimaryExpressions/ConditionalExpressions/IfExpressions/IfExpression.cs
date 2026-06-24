using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Ifs;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ConditionalExpressions.IfExpressions;

public class IfExpression : SwiftCompositeNode, IIfExpression
{
    public If If { get; }
    
    public IConditionList ConditionList { get; }
    
    public LeftCurlyBrace LeftCurlyBrace { get; }

    private readonly List<IStatement> _ifStatements;

    public RightCurlyBrace RightCurlyBrace { get; }

    private readonly List<IElseIfExpression> _elseIfExpressions;
    
    public IElseExpression ElseExpression { get; }

    internal IfExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, If @if,
        IConditionList conditionList, LeftCurlyBrace leftCurlyBrace, List<IStatement> ifStatements,
        RightCurlyBrace rightCurlyBrace, List<IElseIfExpression> elseIfExpressions, IElseExpression elseExpression)
        : base(buffer, children)
    {
        If = @if;
        ConditionList = conditionList;
        
        LeftCurlyBrace = leftCurlyBrace;
        _ifStatements = ifStatements;
        RightCurlyBrace = rightCurlyBrace;
        
        _elseIfExpressions = elseIfExpressions;
        ElseExpression = elseExpression;

        ReturnType = UnknownType.Instance;
    }

    IReadOnlyConditionList IReadOnlyIfExpression.ConditionList => ConditionList;

    public IReadOnlyList<IStatement> IfBlockStatements => _ifStatements;

    IReadOnlyList<IReadOnlyStatement> IReadOnlyIfExpression.IfBlockStatements => IfBlockStatements;

    public IReadOnlyList<IElseIfExpression> ElseIfExpressions => _elseIfExpressions;

    IReadOnlyList<IReadOnlyElseIfExpression> IReadOnlyIfExpression.ElseIfExpressions => ElseIfExpressions;

    IReadOnlyElseExpression IReadOnlyIfExpression.ElseExpression => ElseExpression;

    public IType ReturnType { get; }

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public void ChangeConditionList(IConditionList newConditionList)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeElseExpression(IElseExpression newElseExpression)
    {
        throw new System.NotImplementedException();
    }
}