using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements;

public abstract class StatementInternalNode : SwiftInternalNode, IStatement
{
    public Semicolon? Semicolon { get; internal set; }

    protected StatementInternalNode(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected StatementInternalNode(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected StatementInternalNode(SwiftInternalNode parent, int parentIndex, int parentTextIndex,
        IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, parentIndex, parentTextIndex, buffer, nodes)
    { }

    protected StatementInternalNode(SwiftInternalNode parent, int parentIndex, int parentTextIndex,
        IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, parentIndex, parentTextIndex, buffer, nodes)
    { }

    public virtual bool CanHaveMultipleOnOneLineSeparatedBySemicolons => true;
}