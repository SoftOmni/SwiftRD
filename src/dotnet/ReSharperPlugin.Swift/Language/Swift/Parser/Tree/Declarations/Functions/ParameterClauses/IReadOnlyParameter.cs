using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

public interface IReadOnlyParameter
{
    IReadOnlyIdentifier? ExternalParameterName { get; }
    
    IReadOnlyIdentifier LocalParameterName { get; }
    
    Colon TypePresenter { get; }
    
    IReadOnlyAttributeGroup? Attributes { get; }
    
    IReadOnlyParameterModifier? ParameterModifier { get; }
    
    IReadOnlyType Type { get; }
}
