using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.ConditionalConditionComposing.ParenthesizedCondition;

public class ParenthesizedCompilationCondition : SwiftCompositeNode, IParenthesizedCompilationCondition
{
    public LeftParenthesis LeftParenthesis { get; }
    
    public ICompilationCondition CompilationCondition { get; }
    
    public RightParenthesis RightParenthesis { get; }

    internal ParenthesizedCompilationCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, 
        LeftParenthesis leftParenthesis, ICompilationCondition compilationCondition, RightParenthesis rightParenthesis)
        : base(buffer, children)
    {
        LeftParenthesis = leftParenthesis;
        CompilationCondition = compilationCondition;
        RightParenthesis = rightParenthesis;
    }

    IReadOnlyCompilationCondition IReadOnlyParenthesizedCompilationCondition.CompilationCondition => CompilationCondition;

    public bool Evaluatable()
    {
        throw new NotImplementedException();
    }

    public bool Evaluate()
    {
        throw new NotImplementedException();
    }

    public void ChangeCompilationCondition(ICompilationCondition newCompilationCondition)
    {
        throw new NotImplementedException();
    }
}
