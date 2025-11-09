using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
    CompilationConditions;

public class AndCompilationCondition : CompilationCondition
{
    public CompilationCondition? LeftOperand { get; internal set; }
    
    public Ampersand? FirstAmpersand { get; internal set; }
    
    public Ampersand? SecondAmpersand { get; internal set; }

    public CompilationCondition? RightOperand { get; internal set; }

    internal AndCompilationCondition(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    internal AndCompilationCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    internal AndCompilationCondition(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    internal AndCompilationCondition(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public override bool Evaluatable()
    {
        return (LeftOperand?.Evaluatable() ?? false)
               && (RightOperand?.Evaluatable() ?? false);
    }

    public override bool Evaluate()
    {
        return (LeftOperand?.Evaluate() ?? false)
               && (RightOperand?.Evaluate() ?? false);
    }
}