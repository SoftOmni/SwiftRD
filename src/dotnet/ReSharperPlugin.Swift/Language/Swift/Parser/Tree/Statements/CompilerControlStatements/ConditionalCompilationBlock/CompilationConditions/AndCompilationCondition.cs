using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.
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

    internal AndCompilationCondition(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    internal AndCompilationCondition(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
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