using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.DirectiveClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

public class IfDirective : Directive
{
    public IfDirectiveClause? Clause { get; internal set; }

    internal IfDirective(IEditableBuffer buffer) : base(buffer, SwiftNodeTypes.ReservedIf)
    { }

    internal IfDirective(SwiftInternalNode parent, IEditableBuffer buffer) : base(parent, buffer,
        SwiftNodeTypes.ReservedIf)
    {
        if (parent is IfDirectiveClause clause)
        {
            Clause = clause;
        }
    }

    internal IfDirective(IfDirectiveClause parentClause, IEditableBuffer buffer) : base(parentClause, buffer,
        SwiftNodeTypes.ReservedIf)
    {
        Clause = parentClause;
    }

    public static IfDirective Create()
    {
        return new IfDirective(new EditableBuffer(SwiftNodeTypes.ReservedIf.TokenRepresentation));
    }

    public static IfDirective Create(IfDirectiveClause ifDirectiveClause)
    {
        return new IfDirective(ifDirectiveClause,
            new EditableBuffer(SwiftNodeTypes.ReservedIf.TokenRepresentation)); // TODO: Fix representations
    }

    internal static IfDirective CreateUnchecked(SwiftInternalNode parent)
    {
        return new IfDirective(parent, new EditableBuffer(SwiftNodeTypes.ReservedIf.TokenRepresentation));
    }

    public bool AssociatedToClause => Clause is not null;

    public bool AssociatedToConditionalCompilationBlock =>
        Clause?.ConditionalCompilationBlock is not null;

    public ConditionalCompilationBlock? ConditionalCompilationBlock => Clause?.ConditionalCompilationBlock;
}