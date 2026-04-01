using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.BranchStatements.Switches;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.ForInStatements;

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

    public ForInStatement(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ForInStatement(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}