using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.Wildcards;

public interface IReadOnlyWildcardPattern : IDestructuringPattern
{
    Underscore Underscore { get; }
    
    IReadOnlyTypeAnnotation? TypeAnnotation { get; }
}