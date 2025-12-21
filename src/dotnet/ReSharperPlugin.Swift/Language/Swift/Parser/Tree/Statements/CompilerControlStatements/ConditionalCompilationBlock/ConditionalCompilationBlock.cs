using System.Collections.Generic;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.DirectiveClauses;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock;

public class ConditionalCompilationBlock : CompilerControlStatement
{
    public IfDirectiveClause? IfClause { get; }

    private List<ElseIfDirectiveClause> _elseIfDirectiveClauses;
    
    public ElseDirectiveClause? ElseClause { get; }
    
    public EndIfDirective? EndIfDirective { get; }
    
    public ConditionalCompilationBlock(IEditableBuffer buffer, List<ISwiftNode> children) : base(buffer, children)
    { }

    public ConditionalCompilationBlock(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) : base(buffer, children)
    { }

    public ConditionalCompilationBlock(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }

    public ConditionalCompilationBlock(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }

    public override NodeType NodeType { get; }
    
    public IReadOnlyList<ElseIfDirectiveClause> ElseIfClauses { get; }
}