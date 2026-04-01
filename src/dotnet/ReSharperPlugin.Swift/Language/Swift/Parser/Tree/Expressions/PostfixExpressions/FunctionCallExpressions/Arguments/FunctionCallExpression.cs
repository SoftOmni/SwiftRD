using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

public class FunctionCallExpression : PostfixExpressionInternalNode
{
    public IPostfixExpression? PostfixExpression { get; internal set; }
    
    public LeftParenthesis? LeftParenthesis { get; internal set; }
    
    public FunctionCallArgumentList? FunctionCallArgumentList { get; internal set; }
    
    public RightParenthesis? RightParenthesis { get; internal set; }
    
    public TrailingClosures? TrailingClosures { get; internal set; }
    
    public FunctionCallExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public FunctionCallExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public FunctionCallExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public FunctionCallExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}