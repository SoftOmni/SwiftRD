namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;

public interface IReadOnlyRethrowsInitializerDeclaration : IReadOnlyInitializerDeclaration
{
    Rethrows RethrowsKeyword { get; }
}
