using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

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

    public ArgumentNamesExplicitMemberExpression(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ArgumentNamesExplicitMemberExpression(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}