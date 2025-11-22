using System.Collections.Generic;
using JetBrains.ReSharper.Feature.Services.AI.CodeCompletion.Insertion;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Ifs;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.LoopStatements.Conditions;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.BranchStatements.Guard;

public class GuardStatement : BranchStatement
{
    public Guard? Guard { get; internal set; }
    
    public ConditionList? ConditionList { get; internal set; }
    
    public Else? Else { get; internal set; }
    
    public CodeBlock? CodeBlock { get; internal set; }
    
    public GuardStatement(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GuardStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GuardStatement(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public GuardStatement(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public override bool AllowsBreakStatements => false;
}