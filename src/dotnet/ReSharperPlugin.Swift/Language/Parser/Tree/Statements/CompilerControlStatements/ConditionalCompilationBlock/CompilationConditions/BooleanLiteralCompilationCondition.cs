using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions;

public class BooleanLiteralCompilationCondition : CompilationCondition
{
    public BooleanLiteral BooleanLiteral { get; internal set; }
    
    public BooleanLiteralCompilationCondition(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public BooleanLiteralCompilationCondition(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public BooleanLiteralCompilationCondition(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public BooleanLiteralCompilationCondition(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public override bool Evaluatable()
    {
        throw new System.NotImplementedException();
    }

    public override bool Evaluate()
    {
        throw new System.NotImplementedException();
    }
}