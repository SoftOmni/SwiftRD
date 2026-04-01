using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

public class EndIfDirective : Directive
{
    public ConditionalCompilationBlock? ConditionalCompilationBlock { get; internal set; }
    
    internal EndIfDirective(IEditableBuffer buffer) : base(buffer, SwiftNodeTypes.ReservedEndIf)
    { }

    internal EndIfDirective(SwiftInternalNode parent, IEditableBuffer buffer) : base(parent, buffer,
        SwiftNodeTypes.ReservedEndIf)
    {
        if (parent is ConditionalCompilationBlock conditionalCompilationBlock)
        {
            ConditionalCompilationBlock = conditionalCompilationBlock;
        }
    }

    public static EndIfDirective Create()
    {
        return new EndIfDirective(new EditableBuffer(SwiftNodeTypes.ReservedEndIf.TokenRepresentation));
    }
    
    public static EndIfDirective Create(ConditionalCompilationBlock conditionalCompilationBlock)
    {
        return new EndIfDirective(conditionalCompilationBlock, new EditableBuffer(SwiftNodeTypes.ReservedEndIf.TokenRepresentation));
    }

    internal static EndIfDirective CreateUnchecked(SwiftInternalNode parent)
    {
        return new EndIfDirective(parent, new EditableBuffer(SwiftNodeTypes.ReservedEndIf.TokenRepresentation));
    }
}