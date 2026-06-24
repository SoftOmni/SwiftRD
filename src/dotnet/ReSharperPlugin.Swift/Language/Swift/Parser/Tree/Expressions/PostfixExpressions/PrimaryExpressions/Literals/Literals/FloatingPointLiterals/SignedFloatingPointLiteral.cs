using System;
using System.Numerics;
using ExtendedNumerics;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals.Formatting;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals;

public class SignedFloatingPointLiteral : SwiftCompositeNode, ISignedFloatingPointLiteral
{
    public IOperator? Operator { get; private set; }

    public IReadOnlyFloatingPointLiteral.Sign CurrentSign { get; private set; } =
        IReadOnlyFloatingPointLiteral.Sign.Positive;

    public IFloatingPointLiteral FloatingPointLiteral { get; }
    
    internal SignedFloatingPointLiteral(IEditableBuffer buffer, IFloatingPointLiteral floatingPointLiteral)
        : base(buffer, children: [floatingPointLiteral])
    {
        FloatingPointLiteral = floatingPointLiteral;
    }
    
    internal SignedFloatingPointLiteral(IEditableBuffer buffer, IOperator @operator, IFloatingPointLiteral floatingPointLiteral)
        : base(buffer, children: [@operator, floatingPointLiteral])
    {
        if (@operator.Buffer.Length == 0 && @operator.Buffer[0] == '-')
        {
            CurrentSign = IReadOnlyFloatingPointLiteral.Sign.Negative;
        }
        
        Operator = @operator;
        FloatingPointLiteral = floatingPointLiteral;
    }

    public BigDecimal Value => FloatingPointLiteral.Value;

    public IFloatingPointLiteralFormatting Formatting => FloatingPointLiteral.Formatting;

    public IReadOnlyIntegerLiteral IntegralPartDetachedValue => FloatingPointLiteral.IntegralPartDetachedValue;

    public BigInteger IntegralPartValue => FloatingPointLiteral.IntegralPartValue;

    public int DecimalSeparatorIndex => FloatingPointLiteral.DecimalSeparatorIndex;

    public bool HasDecimalPart => FloatingPointLiteral.HasDecimalPart;

    public IReadOnlyIntegerLiteral? DecimalPartDetachedValue => FloatingPointLiteral.DecimalPartDetachedValue;

    public BigInteger DecimalPartValue => FloatingPointLiteral.DecimalPartValue;

    public int ExponentIndex => FloatingPointLiteral.ExponentIndex;

    public bool HasExponentPart => FloatingPointLiteral.HasExponentPart;

    public IReadOnlyFloatingPointLiteral.Sign ExponentSign => FloatingPointLiteral.ExponentSign;

    public bool HasExplicitExponentSign => FloatingPointLiteral.HasExplicitExponentSign;

    public IReadOnlyIntegerLiteral ExponentValueDetachedValue => FloatingPointLiteral.ExponentValueDetachedValue;

    public BigInteger ExponentValue => FloatingPointLiteral.ExponentValue;

    public int IndexOfNonPresence => FloatingPointLiteral.IndexOfNonPresence;

    IReadOnlyOperator? IReadOnlySignedFloatingPointLiteral.Operator => Operator;

    public IReadOnlyPrimitiveLiteralTypeResolutionContext PrimitiveLiteralTypeResolutionContext
        => FloatingPointLiteral.PrimitiveLiteralTypeResolutionContext;

    public IType ReturnType => FloatingPointLiteral.ReturnType;

    IReadOnlyType IReadOnlyBaseExpression.ReturnType => ReturnType;

    public BigDecimal GetValueCopy()
    {
        return FloatingPointLiteral.GetValueCopy();
    }

    public void SetValue(BigDecimal newValue)
    {
        FloatingPointLiteral.SetValue(newValue);
    }

    public void ChangeFormatting(IFloatingPointLiteralFormatting formatting)
    {
        FloatingPointLiteral.ChangeFormatting(formatting);
    }

    public void MakePositive()
    {
        Operator?.DetachFromParent();

        Operator = null;
        CurrentSign = IReadOnlyFloatingPointLiteral.Sign.Positive;
    }

    public void MakeNegative()
    {
        if (CurrentSign is IReadOnlyFloatingPointLiteral.Sign.Negative)
        {
            return;
        }
        
        UnderlyingBuffer.Insert(0, "-");
        SubEditableBuffer subEditableBuffer = new(UnderlyingBuffer, 0, 1);

        Operator = new Operator(subEditableBuffer);
        CurrentSign = IReadOnlyFloatingPointLiteral.Sign.Negative;
    }

    public void ChangeLiteralContext(IReadOnlyPrimitiveLiteralTypeResolutionContext newContext)
    {
        throw new NotImplementedException();
    }
}