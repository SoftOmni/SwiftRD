using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ProtocolCompositionType;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;

public interface IProtocolCompositionTypeGenericParameter :
    IReadOnlyProtocolCompositionTypeGenericParameter,
    IGenericParameter
{
    new IProtocolCompositionType ProtocolCompositionType { get; }

    void ChangeProtocolCompositionType(IProtocolCompositionType newProtocolCompositionType);
}
