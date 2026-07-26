using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;

public interface ITypeIntroducedGenericParameter :
    IReadOnlyTypeIntroducedGenericParameter,
    IGenericParameter
{
    new IType Type { get; }

    void ChangeType(IType newType);
}
