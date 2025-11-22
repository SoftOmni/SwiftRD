using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.DirectiveClauses;

public class ElseDirectiveClause : DirectiveClause<ElseDirective>
{
    public ElseDirective? ElseDirective => Directive;
    
    internal ElseDirectiveClause(IEditableBuffer buffer, List<ISwiftNode> children) : base(buffer, children)
    { }

    internal ElseDirectiveClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) : base(buffer, children)
    { }

    internal ElseDirectiveClause(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }

    internal ElseDirectiveClause(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }
    
    internal ElseDirectiveClause(ConditionalCompilationBlock parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    internal ElseDirectiveClause(ConditionalCompilationBlock parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}