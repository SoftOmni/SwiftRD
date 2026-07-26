using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ProtocolCompositionType;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;

public interface IReadOnlyProtocolCompositionTypeGenericParameter : IReadOnlyGenericParameter
{
    Colon TypeIdentifierIntroducer { get; }
    
    IReadOnlyProtocolCompositionType ProtocolCompositionType { get; }
}
