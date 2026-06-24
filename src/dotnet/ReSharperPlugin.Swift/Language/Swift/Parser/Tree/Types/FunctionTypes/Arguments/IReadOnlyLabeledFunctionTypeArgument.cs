using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.Arguments;

public interface IReadOnlyLabeledFunctionTypeArgument : IReadOnlyFunctionTypeArgument
{
    IReadOnlyIdentifier Label { get; }
    
    IReadOnlyTypeAnnotation TypeAnnotation { get; }
}
