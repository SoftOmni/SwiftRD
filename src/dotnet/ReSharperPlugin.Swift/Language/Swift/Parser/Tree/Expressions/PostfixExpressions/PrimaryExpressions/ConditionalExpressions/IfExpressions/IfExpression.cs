using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Ifs;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.LoopStatements.Conditions;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ConditionalExpressions.IfExpressions;

public class IfExpression : ConditionalExpression
{
    public If? If { get; internal set; }

    private List<ConditionList> _conditionLists = [];

    private List<(Else @else, If @if)> _elseIfs = [];

    private List<IStatement> _statements = [];
    
    public Else? Else { get; internal set; }

    public IfExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public IfExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public IfExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IfExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IReadOnlyList<ConditionList> Conditions => _conditionLists;

    public IReadOnlyList<(Else @else, If @if)> ElseIfs => _elseIfs;

    public IReadOnlyList<IStatement> Statements => _statements;
}