using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClojureParameterLists;

public interface IReadOnlyTypedClosureParameter : IReadOnlyClosureParameter
{
    IReadOnlyTypeAnnotation? TypeAnnotation { get; }
}
