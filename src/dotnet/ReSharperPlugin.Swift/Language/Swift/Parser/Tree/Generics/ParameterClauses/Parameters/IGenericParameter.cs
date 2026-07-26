using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;

public interface IGenericParameter : IReadOnlyGenericParameter
{
    new IIdentifier GenericParameterName { get; }

    void ChangeGenericParameterName(IIdentifier newGenericParameterName);
}
