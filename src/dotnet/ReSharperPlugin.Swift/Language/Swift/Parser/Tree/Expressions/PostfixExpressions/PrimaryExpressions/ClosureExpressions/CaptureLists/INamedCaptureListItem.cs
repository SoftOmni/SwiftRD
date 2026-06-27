using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    ClosureExpressions.CaptureLists;

public interface INamedCaptureListItem : IReadOnlyNamedCaptureListItem, ICaptureListItem
{
    new IIdentifier Name { get; }

    new IExpression? DefaultValueExpression { get; }

    void ChangeName(IIdentifier name);

    void SetDefaultValueTo(IExpression expression);

    void RemoveDefaultValue();
}