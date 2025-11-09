using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.DirectiveClauses;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

public class IfDirective : Directive
{
    public IfDirectiveClause? Clause { get; internal set; }

    internal IfDirective(IEditableBuffer buffer) : base(buffer, NodeTypes.NodeTypes.ReservedIf)
    { }

    internal IfDirective(ISwiftNode parent, IEditableBuffer buffer) : base(parent, buffer,
        NodeTypes.NodeTypes.ReservedIf)
    {
        if (parent is IfDirectiveClause clause)
        {
            Clause = clause;
        }
    }

    internal IfDirective(IfDirectiveClause parentClause, IEditableBuffer buffer) : base(parentClause, buffer,
        NodeTypes.NodeTypes.ReservedIf)
    {
        Clause = parentClause;
    }

    public static IfDirective Create()
    {
        return new IfDirective(new EditableBuffer(NodeTypes.NodeTypes.ReservedIf.TokenRepresentation));
    }

    public static IfDirective Create(IfDirectiveClause ifDirectiveClause)
    {
        return new IfDirective(ifDirectiveClause,
            new EditableBuffer(NodeTypes.NodeTypes.ReservedIf.TokenRepresentation)); // TODO: Fix representations
    }

    internal static IfDirective CreateUnchecked(ISwiftNode parent)
    {
        return new IfDirective(parent, new EditableBuffer(NodeTypes.NodeTypes.ReservedIf.TokenRepresentation));
    }

    public bool AssociatedToClause => Clause is not null;

    public bool AssociatedToConditionalCompilationBlock =>
        Clause?.ConditionalCompilationBlock is not null;

    public ConditionalCompilationBlock? ConditionalCompilationBlock => Clause?.ConditionalCompilationBlock;
}