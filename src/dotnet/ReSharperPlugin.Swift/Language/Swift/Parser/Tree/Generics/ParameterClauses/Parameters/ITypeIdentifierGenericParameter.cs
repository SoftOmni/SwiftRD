using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;

public interface ITypeIdentifierGenericParameter : 
    IReadOnlyTypeIdentifierGenericParameter,
    IGenericParameter
{
    new ITypeIdentifier TypeIdentifier { get; }

    void ChangeTypeIdentifier(ITypeIdentifier newTypeIdentifier);
}
