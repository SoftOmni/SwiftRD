using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

public interface ILiteral<out TSwiftType, TCSharpValueType> where TSwiftType : Type
{
    public TSwiftType Type { get; }

    public TCSharpValueType Value { get; }

    public TCSharpValueType GetValueCopy();

    public void SetValue(TCSharpValueType newValue);
}