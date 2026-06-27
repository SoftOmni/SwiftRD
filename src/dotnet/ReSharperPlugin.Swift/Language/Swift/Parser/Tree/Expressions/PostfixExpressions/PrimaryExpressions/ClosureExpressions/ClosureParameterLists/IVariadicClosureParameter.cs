using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClojureParameterLists;

public interface IVariadicClosureParameter : IReadOnlyVariadicClosureParameter, IClosureParameter
{
    new ITypeAnnotation TypeAnnotation { get; }

    void ChangeTypeAnnotation(ITypeAnnotation newTypeAnnotation);
}
