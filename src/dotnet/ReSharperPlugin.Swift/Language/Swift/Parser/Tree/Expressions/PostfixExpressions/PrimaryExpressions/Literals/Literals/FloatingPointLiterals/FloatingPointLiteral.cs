using System;
using System.Numerics;
using ExtendedNumerics;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals.Formatting;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.
    Literals.FloatingPointLiterals;

public partial class FloatingPointLiteral : Literal<BigDecimal>, IFloatingPointLiteral
{
    public IReadOnlyFloatingPointLiteral.Base Base { get; private set; }

    public IFloatingPointLiteralFormatting Formatting { get; private set; }

    private readonly IPrimitiveLiteralTypeResolutionContext _primitiveLiteralTypeResolutionContext;

    public FloatingPointLiteral(BigDecimal value,
        IPrimitiveLiteralTypeResolutionContext? primitiveLiteralTypeResolutionContext = null)
        : base(GetBufferFromValue(value, FloatingPointLiteralFormatting.Default()), value)
    {
        Base = IReadOnlyFloatingPointLiteral.Base.Decimal;
        Formatting = FloatingPointLiteralFormatting.Default();
        _primitiveLiteralTypeResolutionContext =
            primitiveLiteralTypeResolutionContext ?? new PrimitiveLiteralTypeResolutionContext();

        DetermineCharacteristicsWithoutFormatting();
        // This is the default as GetBufferFromValue will use default formatting rules
    }

    public FloatingPointLiteral(BigDecimal value, IFloatingPointLiteralFormatting formatting,
        IPrimitiveLiteralTypeResolutionContext? primitiveLiteralTypeResolutionContext = null)
        : base(GetBufferFromValue(value, formatting), value)
    {
        Base = IReadOnlyFloatingPointLiteral.Base.Decimal;
        Formatting = formatting;
        _primitiveLiteralTypeResolutionContext =
            primitiveLiteralTypeResolutionContext ?? new PrimitiveLiteralTypeResolutionContext();

        DetermineCharacteristicsWithoutFormatting();
    }

    public FloatingPointLiteral(IEditableBuffer underlyingBuffer, BigDecimal value,
        IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext)
        : base(underlyingBuffer, value)
    {
        _primitiveLiteralTypeResolutionContext = primitiveLiteralTypeResolutionContext;

        Base = IReadOnlyFloatingPointLiteral.Base.Decimal;
        Formatting = FloatingPointLiteralFormatting.Default();
        DetermineCharacteristics();
    }
    
    public override NodeType NodeType => SwiftNodeTypes.FloatingPointLiteral;

    public BigInteger IntegralPartValue { get; private set; } = BigInteger.Zero;

    public IReadOnlyIntegerLiteral IntegralPartDetachedValue { get; private set; } =
        new IntegerLiteral(BigInteger.Zero);

    public int DecimalSeparatorIndex { get; private set; } = INDEX_OF_NON_PRESENCE;

    public bool HasDecimalPart => DecimalSeparatorIndex != IndexOfNonPresence;

    public BigInteger DecimalPartValue { get; private set; } = BigInteger.Zero;

    public IReadOnlyIntegerLiteral DecimalPartDetachedValue { get; private set; } =
        new IntegerLiteral(BigInteger.Zero);

    public int ExponentIndex { get; private set; } = INDEX_OF_NON_PRESENCE;

    public bool HasExponentPart => ExponentIndex != IndexOfNonPresence;

    public IReadOnlyFloatingPointLiteral.Sign ExponentSign { get; private set; } =
        IReadOnlyFloatingPointLiteral.Sign.Positive;

    public bool HasExplicitExponentSign =>
        Formatting.SignExplicitness is IFloatingPointLiteralFormatting.Explicitness.Explicit;

    public BigInteger ExponentValue { get; private set; } = BigInteger.Zero;

    public IReadOnlyIntegerLiteral ExponentValueDetachedValue { get; private set; } =
        new IntegerLiteral(BigInteger.Zero);

    public int IndexOfNonPresence => INDEX_OF_NON_PRESENCE;

    public override IType ReturnType => _primitiveLiteralTypeResolutionContext.DefaultFloatingPointLiteralType.Type;

    public override BigDecimal GetValueCopy()
    {
        return Value + BigDecimal.Zero;
    }

    public override void SetValue(BigDecimal newValue)
    {
        SetValue(newValue, Formatting);
    }

    public void SetValue(BigDecimal newValue, IFloatingPointLiteralFormatting formatting)
    {
        UnderlyingBuffer.Remove(0, UnderlyingBuffer.Length);
        InsertInBufferFormattedValue(UnderlyingBuffer, newValue, formatting);

        Value = newValue;
        Formatting = formatting; // TODO: update index values of float
    }

    private static IEditableBuffer GetBufferFromValue(BigDecimal value, IFloatingPointLiteralFormatting formatting)
    {
        IEditableBuffer buffer = new EditableBuffer();
        InsertInBufferFormattedValue(buffer, value, formatting);

        return buffer;
    }

    public void ChangeFormatting(IFloatingPointLiteralFormatting formatting)
    {
        if (formatting == Formatting)
        {
            return;
        }


        throw new NotImplementedException();
    }

    private const int INDEX_OF_NON_PRESENCE = -1;

    protected override IReadOnlyPrimitiveLiteralTypeResolutionContext ProvidePrimitiveLiteralTypeResolutionContext()
    {
        return _primitiveLiteralTypeResolutionContext;
    }
}