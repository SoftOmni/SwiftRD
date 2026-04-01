using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions.ArgumentNames;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.InitializerExpressions;

public class InitializerExpression : PostfixExpressionInternalNode
{
    public IPostfixExpression? PostfixExpression { get; internal set; }
    
    public Period? Period { get; internal set; }
    
    public Init? Init { get; internal set; }
    
    public LeftParenthesis? LeftParenthesis { get; internal set; }
    
    public ArgumentNames? ArgumentNames { get; internal set; }
    
    public RightParenthesis? RightParenthesis { get; internal set; }
    
    public InitializerExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public InitializerExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public InitializerExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public InitializerExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}