using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.Directives;

public class EndIfDirective : Directive
{
    public ConditionalCompilationBlock? ConditionalCompilationBlock { get; internal set; }
    
    internal EndIfDirective(IEditableBuffer buffer) : base(buffer, NodeTypes.NodeTypes.ReservedEndIf)
    { }

    internal EndIfDirective(SwiftInternalNode parent, IEditableBuffer buffer) : base(parent, buffer,
        NodeTypes.NodeTypes.ReservedEndIf)
    {
        if (parent is ConditionalCompilationBlock conditionalCompilationBlock)
        {
            ConditionalCompilationBlock = conditionalCompilationBlock;
        }
    }

    public static EndIfDirective Create()
    {
        return new EndIfDirective(new EditableBuffer(NodeTypes.NodeTypes.ReservedEndIf.TokenRepresentation));
    }
    
    public static EndIfDirective Create(ConditionalCompilationBlock conditionalCompilationBlock)
    {
        return new EndIfDirective(conditionalCompilationBlock, new EditableBuffer(NodeTypes.NodeTypes.ReservedEndIf.TokenRepresentation));
    }

    internal static EndIfDirective CreateUnchecked(SwiftInternalNode parent)
    {
        return new EndIfDirective(parent, new EditableBuffer(NodeTypes.NodeTypes.ReservedEndIf.TokenRepresentation));
    }
}