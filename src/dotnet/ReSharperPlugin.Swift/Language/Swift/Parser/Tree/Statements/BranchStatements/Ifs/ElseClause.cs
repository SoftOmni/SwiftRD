using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.CodeBlocks;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.StatementGroups;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Ifs;

public class ElseClause : SwiftInternalNode
{
    public Else? Else { get; private set; }
    
    public IfStatement? RootIfStatement { get; private set; }
    
    public IfStatement? PreviousIfStatement { get; private set; }
    
    public CodeBlock? CodeBlock { get; private set; }
    
    public ElseClause(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ElseClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ElseClause(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ElseClause(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}