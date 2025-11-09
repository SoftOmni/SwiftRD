using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations.Cases;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Patterns;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Switches;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.LoopStatements.ForInStatements;

public class ForInStatement : LoopStatement
{
    public For? For { get; internal set; }
    
    public Case? Case { get; internal set; }
    
    public Pattern? Pattern { get; internal set; }
    
    public In? In { get; internal set; }
    
    public Expression? Expression { get; internal set; }
    
    public WhereClause? WhereClause { get; internal set; }
    
    public ForInStatement(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ForInStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ForInStatement(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ForInStatement(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}