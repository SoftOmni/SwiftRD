using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists.
    CaptureListItems;

public class SelfExpressionCaptureListItems : CaptureListItem
{
    public SelfExpression? SelfExpression { get; internal set; }

    public SelfExpressionCaptureListItems(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SelfExpressionCaptureListItems(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SelfExpressionCaptureListItems(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public SelfExpressionCaptureListItems(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}