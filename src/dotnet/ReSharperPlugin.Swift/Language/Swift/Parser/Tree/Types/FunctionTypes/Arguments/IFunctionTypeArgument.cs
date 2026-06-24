using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.Arguments;

public interface IFunctionTypeArgument : IReadOnlyFunctionTypeArgument
{
    new IAttributeGroup? AttributeGroup { get; }
    
    new IParameterModifier? ParameterModifier { get; }

    void SetAttributeGroupTo(IAttributeGroup? attributeGroup);

    void SetParameterModifierTo(IParameterModifier? parameterModifier);

    void RemoveAttributes();

    void RemoveParameterModifier();
}
