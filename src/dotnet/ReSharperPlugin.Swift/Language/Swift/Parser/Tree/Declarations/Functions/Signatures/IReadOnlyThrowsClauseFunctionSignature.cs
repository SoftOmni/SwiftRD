using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.Signatures;

public interface IReadOnlyThrowsClauseFunctionSignature : IReadOnlyFunctionSignature
{
    IReadOnlyThrowsClause? ThrowsClause { get; }
}
