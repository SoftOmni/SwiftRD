using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions.ArgumentNames;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions;

public interface IExplicitMemberExpressionFunctionMember :
    IReadOnlyExplicitMemberExpressionFunctionMember, IExplicitMemberExpression
{
    new IIdentifier FunctionName { get; }
    
    new IArgumentNames ArgumentNames { get; }
    
    void ChangeFunctionName(IIdentifier newFunctionName);

    void ChangeArguments(IArgumentNames newArguments);
}
