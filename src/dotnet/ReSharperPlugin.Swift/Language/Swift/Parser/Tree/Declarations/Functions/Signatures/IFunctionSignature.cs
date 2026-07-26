using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;

public interface IFunctionSignature : IReadOnlyFunctionSignature
{
    new IParameterClause ParameterClause { get; }
    
    new IFunctionResult? FunctionResult { get; }

    void ChangeParameterClause(IParameterClause newParameterClause);

    void SetFunctionResultTo(IFunctionResult? newFunctionResult);

    void RemoveFunctionResult();
}
