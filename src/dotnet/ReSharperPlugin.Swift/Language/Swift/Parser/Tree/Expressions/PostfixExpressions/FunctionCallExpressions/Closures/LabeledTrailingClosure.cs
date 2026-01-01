using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;

public class LabeledTrailingClosure : SwiftInternalNode
{
    public Identifier? Identifier { get; internal set; }
    
    public Colon? Colon { get; internal set; }
    
    public ClosureExpression? ClosureExpression { get; internal set; }
    
    public LabeledTrailingClosure(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public LabeledTrailingClosure(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public LabeledTrailingClosure(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public LabeledTrailingClosure(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}