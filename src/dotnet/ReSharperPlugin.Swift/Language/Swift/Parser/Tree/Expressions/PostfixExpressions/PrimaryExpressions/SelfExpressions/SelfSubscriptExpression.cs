using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;

public class SelfSubscriptExpression : SelfExpression
{
    public LeftSquareBracket? LeftSquareBracket { get; internal set; }
    
    public FunctionCallArgumentList? ArgumentList { get; internal set; }
    
    public RightSquareBracket? RightSquareBracket { get; internal set; }
    
    public SelfSubscriptExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SelfSubscriptExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SelfSubscriptExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public SelfSubscriptExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}