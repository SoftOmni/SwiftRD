using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.DirectiveClauses;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

public class ElseIfDirective : Directive
{
    public ElseIfDirectiveClause? Clause { get; internal set; }

    internal ElseIfDirective(IEditableBuffer buffer) : base(buffer, NodeTypes.NodeTypes.ReservedElseIf)
    { }

    internal ElseIfDirective(SwiftInternalNode parent, IEditableBuffer buffer) : base(parent, buffer,
        NodeTypes.NodeTypes.ReservedElseIf)
    {
        if (parent is ElseIfDirectiveClause clause)
        {
            Clause = clause;
        }
    }

    internal ElseIfDirective(ElseIfDirectiveClause parentClause, IEditableBuffer buffer) : base(parentClause, buffer,
        NodeTypes.NodeTypes.ReservedIf)
    {
        Clause = parentClause;
    }

    public static ElseIfDirective Create()
    {
        return new ElseIfDirective(new EditableBuffer(NodeTypes.NodeTypes.ReservedElseIf.TokenRepresentation));
    }

    public static ElseIfDirective Create(ElseIfDirectiveClause ifDirectiveClause)
    {
        return new ElseIfDirective(ifDirectiveClause,
            new EditableBuffer(NodeTypes.NodeTypes.ReservedElseIf.TokenRepresentation)); // TODO: Fix representations
    }

    internal static ElseIfDirective CreateUnchecked(SwiftInternalNode parent)
    {
        return new ElseIfDirective(parent, new EditableBuffer(NodeTypes.NodeTypes.ReservedElseIf.TokenRepresentation));
    }

    public bool AssociatedToClause => Clause is not null;

    public bool AssociatedToConditionalCompilationBlock =>
        Clause?.ConditionalCompilationBlock is not null;

    public ConditionalCompilationBlock? ConditionalCompilationBlock => Clause?.ConditionalCompilationBlock;
}