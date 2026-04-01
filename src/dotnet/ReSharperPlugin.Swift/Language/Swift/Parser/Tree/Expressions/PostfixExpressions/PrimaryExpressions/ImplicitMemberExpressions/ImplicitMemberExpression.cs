using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ImplicitMemberExpressions;

public class ImplicitMemberExpression : PrimaryExpressionInternalNode
{
    public Period? InitialPeriod { get; internal set; }
    
    public Identifier? Identifier { get; internal set; }
    
    public Period? SecondPeriod { get; internal set; }
    
    public PostfixExpressionInternalNode? PostfixExpression { get; internal set; }
    
    public ImplicitMemberExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ImplicitMemberExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ImplicitMemberExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ImplicitMemberExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}