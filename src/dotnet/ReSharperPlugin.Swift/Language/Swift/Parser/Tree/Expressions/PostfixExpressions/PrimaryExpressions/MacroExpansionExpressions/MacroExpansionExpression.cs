using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.ArgumentClauses;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.MacroExpansionExpressions;

public class MacroExpansionExpression : PrimaryExpressionInternalNode
{
    public Hash? Hashtag { get; internal set; }
    
    public Identifier? Identifier { get; internal set; }
    
    public GenericArgumentClause? GenericArgumentClause { get; internal set; }
    
    public LeftParenthesis? FunctionCallArgumentClauseLeftParenthesis { get; internal set; }
    
    public RightParenthesis? FunctionCallArgumentClauseRightParenthesis { get; internal set; }
    
    public TrailingClosures? TrailingClosures { get; internal set; }
    
    public MacroExpansionExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public MacroExpansionExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public MacroExpansionExpression(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public MacroExpansionExpression(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}