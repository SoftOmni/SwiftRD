using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists.CaptureListItems;

public class IdentifierAssignmentCaptureListItem : CaptureListItem
{
    public Identifier? Identifier { get; internal set; }
    
    public Equal? Equal { get; internal set; }
    
    public Expression? Expression { get; internal set; }
    
    public IdentifierAssignmentCaptureListItem(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public IdentifierAssignmentCaptureListItem(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public IdentifierAssignmentCaptureListItem(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public IdentifierAssignmentCaptureListItem(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}