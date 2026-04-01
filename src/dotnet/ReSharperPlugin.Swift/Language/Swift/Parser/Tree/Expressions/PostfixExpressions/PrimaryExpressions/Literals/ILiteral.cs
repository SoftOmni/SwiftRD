using SoftOmni.SwiftRd.Language.Semantics.Type;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

public interface ILiteral<out TSwiftType, TCSharpValueType> where TSwiftType : Type
{
    public TSwiftType Type { get; }

    public TCSharpValueType Value { get; }

    public TCSharpValueType GetValueCopy();

    public void SetValue(TCSharpValueType newValue);
}