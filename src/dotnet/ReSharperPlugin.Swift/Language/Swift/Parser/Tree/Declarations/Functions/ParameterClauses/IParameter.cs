using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

public interface IParameter : IReadOnlyParameter
{
    new IIdentifier? ExternalParameterName { get; }
    
    new IIdentifier LocalParameterName { get; }
    
    new IAttributeGroup? Attributes { get; }
    
    new IParameterModifier? ParameterModifier { get; }
    
    new IType Type { get; }

    void SetExternalParameterNameTo(IIdentifier? newExternalParameterName);

    void RemoveExternalParameterName();

    void ChangeLocalParameterName();

    void SetAttributesTo(IAttributeGroup? newAttributes);

    void RemoveAttributes();

    void SetParameterModifier(IParameterModifier? newParameterModifier);

    void RemoveParameterModifier();

    void ChangeType(IType newType);
}
