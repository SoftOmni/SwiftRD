using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    Directives;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    DirectiveClauses;

public abstract class DirectiveClause<TDirective> : SwiftInternalNode where TDirective : Directive
{
    public ConditionalCompilationBlock? ConditionalCompilationBlock { get; }

    public CompilationCondition? CompilationCondition { get; internal set; }

    public TDirective? Directive { get; internal set; }

    protected readonly List<StatementInternalNode> _statements = [];

    protected DirectiveClause(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    {
        SetUpChildren();
    }

    protected DirectiveClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    {
        SetUpChildren();
    }

    protected DirectiveClause(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    {
        if (parent is ConditionalCompilationBlock conditionalCompilationBlock)
        {
            ConditionalCompilationBlock = conditionalCompilationBlock;
        }

        SetUpChildren();
    }

    protected DirectiveClause(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    {
        if (parent is ConditionalCompilationBlock conditionalCompilationBlock)
        {
            ConditionalCompilationBlock = conditionalCompilationBlock;
        }

        SetUpChildren();
    }

    protected DirectiveClause(ConditionalCompilationBlock parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    {
        ConditionalCompilationBlock = parent;
        SetUpChildren();
    }

    protected DirectiveClause(ConditionalCompilationBlock parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    {
        ConditionalCompilationBlock = parent;
        SetUpChildren();
    }

    public IReadOnlyList<StatementInternalNode> Statements => _statements;

    private void SetUpChildren()
    {
        foreach (ISwiftNode? child in _children)
        {
            if (child is CompilationCondition compilationCondition)
            {
                CompilationCondition = compilationCondition;
            }
            else if (child is TDirective directive)
            {
                Directive = directive;
            }
        }
    }
}