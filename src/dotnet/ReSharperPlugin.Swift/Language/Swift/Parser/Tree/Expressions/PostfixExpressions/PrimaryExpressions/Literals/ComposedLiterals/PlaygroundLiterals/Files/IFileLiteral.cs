using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.PlaygroundLiterals.Files;

public interface IFileLiteral : IReadOnlyFileLiteral, IPlaygroundLiteral<IExpression>
{
    new IExpression RessourceNameArgumentValue { get; }

    void ChangeRessourceNameArgumentValue(IExpression newExpression);

    new IExpression GetValueCopy();
    
    new IReadOnlyPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext { get; }
    
    new IExpression Value { get; }
}
