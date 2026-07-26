namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

public interface IReadOnlyMutatingMutationModifier : IReadOnlyMutationModifier
{
    Mutating Mutating { get; }
}
