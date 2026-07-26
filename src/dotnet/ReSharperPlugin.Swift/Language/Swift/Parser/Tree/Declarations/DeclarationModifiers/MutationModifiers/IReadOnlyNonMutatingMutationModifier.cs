namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

public interface IReadOnlyNonMutatingMutationModifier : IReadOnlyMutationModifier
{
    NonMutating NonMutating { get; }
}
