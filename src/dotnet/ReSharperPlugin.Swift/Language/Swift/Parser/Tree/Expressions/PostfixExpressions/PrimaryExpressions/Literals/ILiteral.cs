using SoftOmni.SwiftRd.Language.Semantics.Type;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

public interface ILiteral<out TSwiftType, TCSharpValueType> : IReadOnlyLiteral<TSwiftType, TCSharpValueType> where TSwiftType : Type
{
    public void SetValue(TCSharpValueType newValue);
}