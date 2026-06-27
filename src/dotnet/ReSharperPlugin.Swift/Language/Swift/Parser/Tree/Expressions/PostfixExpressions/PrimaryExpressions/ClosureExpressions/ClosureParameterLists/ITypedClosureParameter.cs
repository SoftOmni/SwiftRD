using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClojureParameterLists;

public interface ITypedClosureParameter : IReadOnlyTypedClosureParameter, IClosureParameter
{
    new ITypeAnnotation? TypeAnnotation { get; }

    void SetTypeAnnotationTo(ITypeAnnotation? typeAnnotation);

    void RemoveTypeAnnotation();
}
