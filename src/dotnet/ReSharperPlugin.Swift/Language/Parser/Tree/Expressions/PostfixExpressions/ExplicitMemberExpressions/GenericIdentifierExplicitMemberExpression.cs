using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.ArgumentClauses;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public class GenericIdentifierExplicitMemberExpression : ExplicitMemberExpression
{
    public Identifier? Identifier { get; internal set; }
    
    public GenericArgumentClause? GenericArgumentClause { get; internal set; }
    
    public GenericIdentifierExplicitMemberExpression(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public GenericIdentifierExplicitMemberExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public GenericIdentifierExplicitMemberExpression(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public GenericIdentifierExplicitMemberExpression(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}