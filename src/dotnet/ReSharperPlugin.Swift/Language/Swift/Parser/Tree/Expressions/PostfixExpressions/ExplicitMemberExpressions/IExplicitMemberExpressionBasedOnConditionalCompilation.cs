using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public interface
    IExplicitMemberExpressionBasedOnConditionalCompilation :
    IReadOnlyExplicitMemberExpressionBasedOnConditionalCompilation, IExplicitMemberExpression
{
    new IConditionalCompilationBlock ConditionalCompilationBlock { get; }

    void ChangeConditionalCompilationBlock(IConditionalCompilationBlock newConditionalCompilationBlock);
}
