using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public interface IInitializer : IReadOnlyInitializer
{
    new IExpression Expression { get; }

    void ChangeExpression(IExpression newExpression);
}
