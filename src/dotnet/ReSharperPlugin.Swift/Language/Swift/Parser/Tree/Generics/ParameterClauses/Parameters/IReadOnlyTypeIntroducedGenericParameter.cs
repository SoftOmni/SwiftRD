using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses.Parameters;

public interface IReadOnlyTypeIntroducedGenericParameter : IReadOnlyGenericParameter
{
    Let LetKeyword { get; }
    
    Colon TypeIntroducer { get; }
    
    IReadOnlyType Type { get; }
    
    IReadOnlyOperator Backslash { get; }
}
