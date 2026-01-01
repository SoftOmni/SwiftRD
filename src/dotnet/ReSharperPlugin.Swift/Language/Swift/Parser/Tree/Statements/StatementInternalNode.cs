using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements;

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