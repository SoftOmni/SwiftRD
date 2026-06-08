using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;

public interface IGenericArgument
{
    IType? Type { get; }
    
    IGenericArgumentDefinition? GenericArgumentDefinition { get; }

    bool IsValid();

    bool AreConstraintsSatisfied();
}