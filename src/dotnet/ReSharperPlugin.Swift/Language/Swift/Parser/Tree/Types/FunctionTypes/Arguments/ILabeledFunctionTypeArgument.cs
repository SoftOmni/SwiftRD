using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.Arguments;

public interface ILabeledFunctionTypeArgument : IReadOnlyLabeledFunctionTypeArgument, IFunctionTypeArgument
{
    new IIdentifier Label { get; }
    
    new ITypeAnnotation TypeAnnotation { get; }

    void ChangeLabel(IIdentifier identifier);

    void ChangeTypeAnnotation(ITypeAnnotation typeAnnotation);
}
