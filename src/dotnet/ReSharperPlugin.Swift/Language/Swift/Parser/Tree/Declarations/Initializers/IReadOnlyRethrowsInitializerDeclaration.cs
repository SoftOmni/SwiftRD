namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;

public interface IReadOnlyRethrowsInitializeDeclaration : IReadOnlyInitializerDeclaration
{
    Rethrows RethrowsKeyword { get; }
}
