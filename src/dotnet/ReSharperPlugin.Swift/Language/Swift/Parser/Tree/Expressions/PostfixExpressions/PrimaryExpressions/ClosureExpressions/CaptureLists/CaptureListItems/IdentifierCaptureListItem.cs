using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists.CaptureListItems;

public class IdentifierCaptureListItem : CaptureListItem
{
    public Identifier? Identifier { get; internal set; }
    
    public IdentifierCaptureListItem(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public IdentifierCaptureListItem(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public IdentifierCaptureListItem(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IdentifierCaptureListItem(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}