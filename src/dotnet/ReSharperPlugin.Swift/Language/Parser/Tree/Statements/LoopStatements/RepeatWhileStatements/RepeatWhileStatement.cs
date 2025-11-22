using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Statements.LoopStatements.WhileLoops;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.LoopStatements.RepeatWhileStatements;

public class RepeatWhileStatement : LoopStatement
{
    public Repeat? Repeat { get; internal set; }
    
    public While? While { get; internal set; }
    
    public Expression? Expression { get; internal set; }

    public RepeatWhileStatement(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public RepeatWhileStatement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public RepeatWhileStatement(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public RepeatWhileStatement(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}