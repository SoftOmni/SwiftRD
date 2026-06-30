
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    MacroExpansionExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace DefaultNamespace;

public interface IMacroExpansionExpression : IReadOnlyMacroExpansionExpression, IPrimaryExpression
{
    new IIdentifier Name { get; }

    new IGenericArgumentClause? GenericArgumentClause { get; }

    new IFunctionCallArgumentList? ParametersClause { get; }
    
    new ITrailingClosuresGroup? TrailingClosureParameters { get; }

    void ChangeName(IIdentifier newName);

    void SetGenericArgumentClause(IGenericArgumentClause? newGenericArgumentClause);

    void RemoveGenericArgumentClause();

    void SetParametersClause(IFunctionCallArgumentList? newParametersClause);

    void RemoveParametersClause();

    void SetTrailingClosureParameters(ITrailingClosuresGroup? newTrailingClosureParameters);

    void RemoveTRailingClosuresGroup();
}
