using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.DirectiveClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

public class ElseDirective : Directive
{
    public ElseDirectiveClause? Clause { get; internal set; }

    internal ElseDirective(IEditableBuffer buffer) : base(buffer, SwiftNodeTypes.ReservedElse)
    { }

    internal ElseDirective(SwiftInternalNode parent, IEditableBuffer buffer) : base(parent, buffer,
        SwiftNodeTypes.ReservedElse)
    {
        if (parent is ElseDirectiveClause clause)
        {
            Clause = clause;
        }
    }

    internal ElseDirective(ElseDirectiveClause parentClause, IEditableBuffer buffer) : base(parentClause, buffer,
        SwiftNodeTypes.ReservedElse)
    {
        Clause = parentClause;
    }

    public static ElseDirective Create()
    {
        return new ElseDirective(new EditableBuffer(SwiftNodeTypes.ReservedElse.TokenRepresentation));
    }

    public static ElseDirective Create(IfDirectiveClause ifDirectiveClause)
    {
        return new ElseDirective(ifDirectiveClause,
            new EditableBuffer(SwiftNodeTypes.ReservedElse.TokenRepresentation)); // TODO: Fix representations
    }

    internal static ElseDirective CreateUnchecked(SwiftInternalNode parent)
    {
        return new ElseDirective(parent, new EditableBuffer(SwiftNodeTypes.ReservedElse.TokenRepresentation));
    }

    public bool AssociatedToClause => Clause is not null;

    public bool AssociatedToConditionalCompilationBlock =>
        Clause?.ConditionalCompilationBlock is not null;

    public ConditionalCompilationBlock? ConditionalCompilationBlock => Clause?.ConditionalCompilationBlock;
}