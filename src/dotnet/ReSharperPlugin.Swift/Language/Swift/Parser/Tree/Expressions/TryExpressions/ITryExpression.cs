namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.TryOperators;

public interface ITryExpression : IReadOnlyTryExpression, IBaseExpression
{
    void MakeSimpleTryExpression();
    
    void MakeOptionalTryExpression();

    void MakeForcedTryExpression();

    new IExpression? TargetExpression { get; }
}
