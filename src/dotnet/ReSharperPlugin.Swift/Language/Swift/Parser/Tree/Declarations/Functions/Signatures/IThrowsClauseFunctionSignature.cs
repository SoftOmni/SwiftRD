using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;

public interface IThrowsClauseFunctionSignature :
    IReadOnlyThrowsClauseFunctionSignature,
    IFunctionSignature
{
    new IThrowsClause? ThrowsClause { get; }

    void SetThrowsClauseTo(IThrowsClause? newThrowsClause);

    void RemoveThrowsClause();
}
