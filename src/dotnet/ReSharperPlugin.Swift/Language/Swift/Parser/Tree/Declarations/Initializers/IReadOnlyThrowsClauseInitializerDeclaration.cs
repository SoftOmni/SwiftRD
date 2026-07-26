using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;

public interface IReadOnlyThrowsClauseInitializerDeclaration : IReadOnlyInitializerDeclaration
{
    IReadOnlyThrowsClause? ThrowsClause { get; }
}
