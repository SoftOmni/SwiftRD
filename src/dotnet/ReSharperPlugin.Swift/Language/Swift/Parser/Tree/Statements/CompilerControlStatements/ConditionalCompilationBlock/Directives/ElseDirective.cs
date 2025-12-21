using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.DirectiveClauses;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

public class ElseDirective : Directive
{
    public ElseDirectiveClause? Clause { get; internal set; }

    internal ElseDirective(IEditableBuffer buffer) : base(buffer, NodeTypes.NodeTypes.ReservedElse)
    { }

    internal ElseDirective(SwiftInternalNode parent, IEditableBuffer buffer) : base(parent, buffer,
        NodeTypes.NodeTypes.ReservedElse)
    {
        if (parent is ElseDirectiveClause clause)
        {
            Clause = clause;
        }
    }

    internal ElseDirective(ElseDirectiveClause parentClause, IEditableBuffer buffer) : base(parentClause, buffer,
        NodeTypes.NodeTypes.ReservedElse)
    {
        Clause = parentClause;
    }

    public static ElseDirective Create()
    {
        return new ElseDirective(new EditableBuffer(NodeTypes.NodeTypes.ReservedElse.TokenRepresentation));
    }

    public static ElseDirective Create(IfDirectiveClause ifDirectiveClause)
    {
        return new ElseDirective(ifDirectiveClause,
            new EditableBuffer(NodeTypes.NodeTypes.ReservedElse.TokenRepresentation)); // TODO: Fix representations
    }

    internal static ElseDirective CreateUnchecked(SwiftInternalNode parent)
    {
        return new ElseDirective(parent, new EditableBuffer(NodeTypes.NodeTypes.ReservedElse.TokenRepresentation));
    }

    public bool AssociatedToClause => Clause is not null;

    public bool AssociatedToConditionalCompilationBlock =>
        Clause?.ConditionalCompilationBlock is not null;

    public ConditionalCompilationBlock? ConditionalCompilationBlock => Clause?.ConditionalCompilationBlock;
}