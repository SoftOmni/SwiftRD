using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions;

public class TernaryOperator : SwiftInternalNode
{
    public QuestionMark? QuestionMark { get; internal set; }
    
    public Expression? Expression { get; internal set; }
    
    public Colon? Colon { get; internal set; }
    
    public TernaryOperator(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public TernaryOperator(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public TernaryOperator(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public TernaryOperator(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}