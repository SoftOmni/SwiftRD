using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    ClosureExpressions.ClojureParameterLists;

public interface IClosureParameter : IReadOnlyClosureParameter
{
    new IIdentifier Name { get; }

    void ChangeName(IIdentifier newName);
}