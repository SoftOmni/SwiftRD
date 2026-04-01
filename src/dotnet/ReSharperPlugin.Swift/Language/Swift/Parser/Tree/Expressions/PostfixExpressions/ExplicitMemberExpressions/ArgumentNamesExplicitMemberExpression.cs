using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public class ArgumentNamesExplicitMemberExpression : ExplicitMemberExpression
{
    public Identifier? Identifier { get; internal set; }
    
    public LeftParenthesis? LeftParenthesis { get; internal set; }
    
    public ArgumentNames.ArgumentNames? ArgumentNames { get; internal set; }
    
    public RightParenthesis? RightParenthesis { get; internal set; }
    
    public ArgumentNamesExplicitMemberExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ArgumentNamesExplicitMemberExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ArgumentNamesExplicitMemberExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ArgumentNamesExplicitMemberExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}