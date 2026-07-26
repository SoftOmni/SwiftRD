using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;

public interface IReadOnlyTypeIdentifierGenericParameter : IReadOnlyGenericParameter
{ 
    Colon TypeIdentifierIntroducer { get; }
    
    IReadOnlyTypeIdentifier TypeIdentifier { get; }
}
