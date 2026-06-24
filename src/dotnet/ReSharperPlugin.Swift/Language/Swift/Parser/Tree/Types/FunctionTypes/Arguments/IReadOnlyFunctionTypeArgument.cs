using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.Arguments;

public interface IReadOnlyFunctionTypeArgument
{
    IReadOnlyAttributeGroup? AttributeGroup { get; }
    
    IReadOnlyParameterModifier? ParameterModifier { get; }
}
