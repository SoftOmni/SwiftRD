using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Semantics.Type;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public abstract class Literal<TSwiftType, TCSharpValueType> : LiteralExpressionLeafNode, ILiteral<TSwiftType, TCSharpValueType> where TSwiftType : Type
{
    protected Literal(IEditableBuffer underlyingBuffer, TSwiftType type, TCSharpValueType value)
        : base(underlyingBuffer)
    {
        Type = type;
        Value = value;
    }

    protected Literal(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex, int parentTextIndex, TSwiftType type, TCSharpValueType value)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    {
        Type = type;
        Value = value;
    }

    public TSwiftType Type { get; }
    
    public TCSharpValueType Value { get; protected set; }

    public int ValueStart { get; protected set; } = 0;

    public abstract TCSharpValueType GetValueCopy();

    public abstract void SetValue(TCSharpValueType newValue);
}