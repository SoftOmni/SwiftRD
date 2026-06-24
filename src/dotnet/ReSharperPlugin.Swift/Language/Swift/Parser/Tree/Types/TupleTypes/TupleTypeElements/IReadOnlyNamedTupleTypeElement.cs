using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

public interface IReadOnlyNamedTupleTypeElement : IReadOnlyTupleTypeElement
{
    IReadOnlyIdentifier ElementName { get; }
    
    IReadOnlyTypeAnnotation TypeAnnotation { get; }
}
