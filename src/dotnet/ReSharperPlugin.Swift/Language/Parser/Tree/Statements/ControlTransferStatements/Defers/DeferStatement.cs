using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.CodeBlocks;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.ControlTransferStatements.Defers;

public class DeferStatement : StatementInternalNode
{
    public Defer? Defer { get; internal set; }
    
    public CodeBlock? CodeBlock { get; internal set; }
    
    public DeferStatement(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public DeferStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public DeferStatement(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public DeferStatement(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}