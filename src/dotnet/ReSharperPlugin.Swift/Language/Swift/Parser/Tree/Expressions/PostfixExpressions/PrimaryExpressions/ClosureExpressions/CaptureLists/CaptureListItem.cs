using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;

public abstract class CaptureListItem : SwiftInternalNode
{
    public ICaptureSpecifier? CaptureSpecifier { get; internal set; }

    protected CaptureListItem(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected CaptureListItem(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected CaptureListItem(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    protected CaptureListItem(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}