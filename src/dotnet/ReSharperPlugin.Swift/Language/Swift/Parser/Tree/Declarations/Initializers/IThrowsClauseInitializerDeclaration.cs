using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;

public interface IThrowsClauseInitializerDeclaration :
    IReadOnlyThrowsClauseInitializerDeclaration,
    IInitializerDeclaration
{
    new IThrowsClause? ThrowsClause { get; }

    void SetThrowsClauseTo(IThrowsClause? newThrowsClause);

    void RemoveThrowsClause();
}
