using System;
using System.Numerics;
using ExtendedNumerics;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals.Formatting;
using ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;
using Double = SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes.Double;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals;

public partial class FloatingPointLiteral : Literal<Double, BigDecimal>, IFloatingPointLiteral
{
    public IReadOnlyFloatingPointLiteral.Base Base { get; private set; }

    public IFloatingPointLiteralFormatting Formatting { get; private set; }

    public FloatingPointLiteral(BigDecimal value)
        : base(GetBufferFromValue(value, FloatingPointLiteralFormatting.Default()), Double.Instance, value)
    {
        Base = IReadOnlyFloatingPointLiteral.Base.Decimal;
        Formatting = FloatingPointLiteralFormatting.Default();
        
        DetermineCharacteristicsWithoutFormatting();
        // This is the default as GetBufferFromValue will use default formatting rules
    }

    public FloatingPointLiteral(BigDecimal value, IFloatingPointLiteralFormatting formatting)
        : base(GetBufferFromValue(value, formatting), Double.Instance, value)
    {
        Base = IReadOnlyFloatingPointLiteral.Base.Decimal;
        Formatting = formatting;
        
        DetermineCharacteristicsWithoutFormatting();
    }

    public FloatingPointLiteral(IEditableBuffer underlyingBuffer, BigDecimal value)
        : base(underlyingBuffer, Double.Instance, value)
    {
        Base = IReadOnlyFloatingPointLiteral.Base.Decimal;
        Formatting = FloatingPointLiteralFormatting.Default();
        DetermineCharacteristics();
    }

    public FloatingPointLiteral(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex,
        int parentTextIndex, BigDecimal value)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex, Double.Instance, value)
    {
        Base = IReadOnlyFloatingPointLiteral.Base.Decimal;
        Formatting = FloatingPointLiteralFormatting.Default();
        DetermineCharacteristics();
    }

    public override NodeType NodeType => SwiftNodeTypes.FloatingPointLiteral;

    public BigInteger IntegralPartValue { get; private set; } = BigInteger.Zero;

    public IReadOnlyIntegerLiteral IntegralPartDetachedValue { get; private set; } = new IntegerLiteral(BigInteger.Zero);

    public int DecimalSeparatorIndex { get; private set; } = INDEX_OF_NON_PRESENCE;

    public bool HasDecimalPart => DecimalSeparatorIndex != IndexOfNonPresence;

    public BigInteger DecimalPartValue { get; private set; } = BigInteger.Zero;

    public IReadOnlyIntegerLiteral DecimalPartDetachedValue { get; private set; } =
        new IntegerLiteral(BigInteger.Zero);

    public int ExponentIndex { get; private set; } = INDEX_OF_NON_PRESENCE;

    public bool HasExponentPart => ExponentIndex != IndexOfNonPresence;

    public IReadOnlyFloatingPointLiteral.Sign ExponentSign { get; private set; } = IReadOnlyFloatingPointLiteral.Sign.Positive;

    public bool HasExplicitExponentSign =>
        Formatting.SignExplicitness is IFloatingPointLiteralFormatting.Explicitness.Explicit;

    public BigInteger ExponentValue { get; private set; } = BigInteger.Zero;

    public IReadOnlyIntegerLiteral ExponentValueDetachedValue { get; private set; } =
        new IntegerLiteral(BigInteger.Zero);

    public int IndexOfNonPresence => INDEX_OF_NON_PRESENCE;

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
}