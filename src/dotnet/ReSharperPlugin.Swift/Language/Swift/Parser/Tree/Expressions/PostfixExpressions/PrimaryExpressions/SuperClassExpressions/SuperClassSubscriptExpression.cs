using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SuperExpressions;

public class SuperClassSubscriptExpression : SuperClassExpression
{
    public LeftSquareBracket? LeftSquareBracket { get; internal set; }
    
    public FunctionCallArgumentList? ArgumentList { get; internal set; }
    
    public RightSquareBracket? RightSquareBracket { get; internal set; }
    
    public SuperClassSubscriptExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SuperClassSubscriptExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SuperClassSubscriptExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public SuperClassSubscriptExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}