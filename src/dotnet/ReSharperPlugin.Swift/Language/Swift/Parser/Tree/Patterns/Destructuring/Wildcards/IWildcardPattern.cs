using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.Wildcards;

public interface IWildcardPattern : IReadOnlyWildcardPattern
{
    new ITypeAnnotation? TypeAnnotation { get; }
    
    void SetTypeAnnotation(ITypeAnnotation typeAnnotation);
}