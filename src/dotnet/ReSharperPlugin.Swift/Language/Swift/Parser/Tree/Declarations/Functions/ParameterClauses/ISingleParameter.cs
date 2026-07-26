using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

public interface ISingleParameter :
    IReadOnlySingleParameter, IParameter
{
    new IExpression? DefaultExpression { get; }

    void SetDefaultExpressionTo(IExpression? newDefaultExpression);

    void RemoveDefaultExpression();
}
