using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Patterns;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Switches;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.DoStatements;

public class CatchPattern : SwiftInternalNode
{
    public Pattern? Pattern { get; internal set; }
    
    public WhereClause? WhereClause { get; internal set; }
    
    public CatchPattern(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public CatchPattern(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public CatchPattern(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public CatchPattern(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}