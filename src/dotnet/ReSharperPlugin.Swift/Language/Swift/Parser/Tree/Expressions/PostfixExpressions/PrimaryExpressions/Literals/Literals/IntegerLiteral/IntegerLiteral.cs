using System;
using System.Numerics;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;

public partial class IntegerLiteral : Literal<Int, BigInteger>
{
    public IntegerLiteral(IEditableBuffer buffer)
        : base(buffer, SwiftNodeTypes.IntegerLiteral)
    {
        ParseValue(buffer);
        DeduceType();
    }

    public IntegerLiteral(SwiftInternalNode parent, IEditableBuffer buffer)
        : base(parent, buffer, SwiftNodeTypes.IntegerLiteral)
    {
        ParseValue(buffer);
        DeduceType();
    }

    public IntegerLiteral(BigInteger value)
        : base(new EditableBuffer(value.ToString()), SwiftNodeTypes.IntegerLiteral)
    { }
    
    public IntegerLiteral(SwiftInternalNode parent, BigInteger value)
        : base(parent, new EditableBuffer(value.ToString()), SwiftNodeTypes.IntegerLiteral)
    { }

    internal IntegerLiteral(IEditableBuffer buffer, BigInteger value)
        : base(buffer, SwiftNodeTypes.IntegerLiteral)
    {
        Value = value;
        DeduceType();
    }

    internal IntegerLiteral(SwiftInternalNode parent, IEditableBuffer buffer, BigInteger value)
        : base(parent, buffer, SwiftNodeTypes.IntegerLiteral)
    {
        Value = value;
        DeduceType();
    }

    public Int Type { get; private set; } = Int.Instance;

    public BigInteger Value { get; private set; } = BigInteger.Zero;

    public override BigInteger GetValueCopy()
    {
        return Value + BigInteger.Zero;
    }

    public override void SetValue(BigInteger newValue)
    {
        throw new NotImplementedException();
    }

    private void DeduceType()
    {
        Type = Int.Instance;
    }
}