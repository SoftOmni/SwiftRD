namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.ComposedLiterals.DictionaryLiterals;

public interface IDictionaryLiteralElement : IReadOnlyDictionaryLiteralElement
{
    new IExpression KeyExpression { get; }
    
    new IExpression ValueExpression { get; }

    void ChangeKeyExpression(IExpression newKeyExpression);

    void ChangeValueExpression(IExpression newValueExpression);
}
