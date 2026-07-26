using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

public interface INamedTupleTypeElement : IReadOnlyNamedTupleTypeElement, ITupleTypeElement
{
    new IIdentifier ElementName { get; }
    
    new ITypeAnnotation TypeAnnotation { get; }
    
    void ChangeElementName(IIdentifier identifier);
    
    void ChangeTypeAnnotation(ITypeAnnotation typeAnnotation);
}
