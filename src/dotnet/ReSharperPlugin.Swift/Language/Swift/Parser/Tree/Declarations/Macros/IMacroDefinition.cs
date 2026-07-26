using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Macros;

public interface IMacroDefinition : IReadOnlyMacroDefinition
{
    new IExpression Expression { get; }

    void ChangeExpression(IExpression newExpression);
}
