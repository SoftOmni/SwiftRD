namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

public interface ISpecificTypeThrowsClause : IReadOnlySpecificTypeThrowsClause, IThrowsClause
{
    new IType ErrorType { get; }

    void ChangeErrorType(IType type);
}
