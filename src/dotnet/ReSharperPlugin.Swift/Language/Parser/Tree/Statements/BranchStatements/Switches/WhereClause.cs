using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.GenericWhereClauseClauses;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Switches;

public class WhereClause : SwiftInternalNode
{
    public Where? Where { get; internal set; }
    
    public Expression? Expression { get; internal set; }

    public WhereClause(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public WhereClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public WhereClause(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public WhereClause(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}