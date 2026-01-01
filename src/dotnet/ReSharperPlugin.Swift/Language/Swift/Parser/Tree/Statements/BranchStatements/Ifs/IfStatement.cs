using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.CodeBlocks;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.LoopStatements.Conditions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.StatementGroups;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Ifs;

public class IfStatement : BranchStatement
{
    public If? If { get; private set; }
    
    public IfStatement? RootIfStatement { get; private set; }

    public IfStatement? PreviousIfStatement { get; private set; }

    public ConditionList? ConditionList { get; private set; }
    
    public CodeBlock? CodeBlock { get; private set; }
    
    public List<IfStatement> IfStatements { get; private set; }
    
    public ElseClause? ElseClause { get; private set; }
    
    public IfStatement(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public IfStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public IfStatement(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public IfStatement(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public override bool AllowsBreakStatements => true;
}