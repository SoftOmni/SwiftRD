using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions;

public class NotCompilationCondition : CompilationCondition
{
    public ExclamationMark? ExclamationMark { get; internal set; }
    
    public CompilationCondition? CompilationCondition { get; internal set; }
    
    internal NotCompilationCondition(IEditableBuffer buffer, List<ISwiftNode> children) : base(buffer, children)
    { }

    internal NotCompilationCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) : base(buffer, children)
    { }

    internal NotCompilationCondition(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }

    internal NotCompilationCondition(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) : base(parent, buffer, nodes)
    { }

    public override bool Evaluatable()
    {
        return CompilationCondition?.Evaluatable() ?? false;
    }

    public override bool Evaluate()
    {
        if (CompilationCondition is null)
        {
            return false;
        }

        return !CompilationCondition.Evaluate();
    }
}