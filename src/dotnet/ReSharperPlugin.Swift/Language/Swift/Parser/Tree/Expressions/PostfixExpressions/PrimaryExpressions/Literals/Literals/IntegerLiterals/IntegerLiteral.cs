using System.Numerics;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals.Formatting;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Semantics.PrimitiveLiterals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;

public partial class IntegerLiteral : Literal<BigInteger>, IIntegerLiteral
{
    private readonly IPrimitiveLiteralTypeResolutionContext _primitiveLiteralTypeResolutionContext;

    public IntegerLiteral(BigInteger value,
        IPrimitiveLiteralTypeResolutionContext? primitiveLiteralTypeResolutionContext = null)
        : base(GetBufferFromValue(value), value)
    {
        _primitiveLiteralTypeResolutionContext =
            primitiveLiteralTypeResolutionContext ?? new PrimitiveLiteralTypeResolutionContext();
        CurrentFormatting = IntegerLiteralFormatting.CurrentDefaultForBase(IReadOnlyIntegerLiteral.Base.Decimal);
        DeduceAttributes();
    }

    public IntegerLiteral(BigInteger value, IReadOnlyIntegerLiteral.Base @base,
        IPrimitiveLiteralTypeResolutionContext? primitiveLiteralTypeResolutionContext = null)
        : base(GetBufferFromValue(value, @base), value)
    {
        _primitiveLiteralTypeResolutionContext =
            primitiveLiteralTypeResolutionContext ?? new PrimitiveLiteralTypeResolutionContext();
        CurrentFormatting = IntegerLiteralFormatting.CurrentDefaultForBase(@base);
        DeduceAttributes();
    }

    public IntegerLiteral(BigInteger value, IIntegerLiteralFormatting formatting,
        IPrimitiveLiteralTypeResolutionContext? primitiveLiteralTypeResolutionContext = null)
        : base(GetBufferFromValue(value, formatting), value)
    {
        _primitiveLiteralTypeResolutionContext =
            primitiveLiteralTypeResolutionContext ?? new PrimitiveLiteralTypeResolutionContext();
        CurrentFormatting = IntegerLiteralFormatting.CurrentDefaultForBase(IReadOnlyIntegerLiteral.Base.Decimal);
        DeduceAttributes();
    }

    public IntegerLiteral(BigInteger value, IReadOnlyIntegerLiteral.Base @base,
        IIntegerLiteralFormatting formatting,
        IPrimitiveLiteralTypeResolutionContext? primitiveLiteralTypeResolutionContext = null)
        : base(GetBufferFromValue(value, @base, formatting), value)
    {
        _primitiveLiteralTypeResolutionContext =
            primitiveLiteralTypeResolutionContext ?? new PrimitiveLiteralTypeResolutionContext();
        CurrentFormatting = IntegerLiteralFormatting.CurrentDefaultForBase(@base);
        DeduceAttributes();
    }

    internal IntegerLiteral(IEditableBuffer underlyingBuffer, BigInteger value,
        IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext)
        : base(underlyingBuffer, value)
    {
        _primitiveLiteralTypeResolutionContext = primitiveLiteralTypeResolutionContext;
        DeduceAttributesWithoutFormatting();
        CurrentFormatting = DeduceFormatting();
    }

    internal IntegerLiteral(IEditableBuffer underlyingBuffer, BigInteger value,
        IReadOnlyIntegerLiteral.Base @base,
        IPrimitiveLiteralTypeResolutionContext primitiveLiteralTypeResolutionContext,
        IIntegerLiteralFormatting? strategy = null,
        IIntegerLiteralFormatting.HexadecimalMode? hexadecimalMode = null)
        : base(underlyingBuffer, value)
    {
        CurrentBase = @base;
        _primitiveLiteralTypeResolutionContext = primitiveLiteralTypeResolutionContext;
        CurrentFormatting = strategy ?? DeduceFormatting();
        CurrentHexadecimalMode = hexadecimalMode;
    }

    public override IType ReturnType => _primitiveLiteralTypeResolutionContext.DefaultIntegerLiteralType.Type;

    public override NodeType NodeType => SwiftNodeTypes.IntegerLiteral;

    public IReadOnlyIntegerLiteral.Base CurrentBase { get; private set; }

    public IIntegerLiteralFormatting CurrentFormatting { get; private set; }

    public IIntegerLiteralFormatting.HexadecimalMode? CurrentHexadecimalMode { get; private set; }

    public override BigInteger GetValueCopy()
    {
        return Value + BigInteger.Zero;
    }

    public override void SetValue(BigInteger newValue)
    {
        ChangeBufferWithValue(UnderlyingBuffer, newValue, CurrentBase, CurrentFormatting);
        Value = newValue;
    }

    public void MakeBinary(IIntegerLiteralFormatting formatting)
    {
        ChangeBufferWithValue(UnderlyingBuffer, Value, IReadOnlyIntegerLiteral.Base.Binary, formatting);
    }

    public void MakeOctal(IIntegerLiteralFormatting formatting)
    {
        ChangeBufferWithValue(UnderlyingBuffer, Value, IReadOnlyIntegerLiteral.Base.Octal, formatting);
    }

    public void MakeDecimal(IIntegerLiteralFormatting formatting)
    {
        ChangeBufferWithValue(UnderlyingBuffer, Value, IReadOnlyIntegerLiteral.Base.Decimal, formatting);
    }

    public void MakeHexadecimal(IIntegerLiteralFormatting formatting)
    {
        ChangeBufferWithValue(UnderlyingBuffer, Value, IReadOnlyIntegerLiteral.Base.Hexadecimal, formatting);
    }

    public void ChangeFormatting(IIntegerLiteralFormatting formatting)
    {
        ChangeBufferWithValue(UnderlyingBuffer, Value, CurrentBase, formatting);
    }

    public void MakeUppercaseIfInHex()
    {
        if (CurrentBase is not IReadOnlyIntegerLiteral.Base.Hexadecimal)
        {
            return;
        }

        const int difference = 'a' - 'A';

        for (int i = ValueStart; i < GetTextLength(); i++)
        {
            char character = Buffer[i];

            if (character is >= 'a' and <= 'f')
            {
                UnderlyingBuffer.Replace(i, 1, ((char)(character - difference)).ToString());
            }
        }
    }

    public void MakeLowercaseIfInHex()
    {
        if (CurrentBase is not IReadOnlyIntegerLiteral.Base.Hexadecimal)
        {
            return;
        }

        const int difference = 'a' - 'A';

        for (int i = ValueStart; i < GetTextLength(); i++)
        {
            char character = Buffer[i];

            if (character is >= 'a' and <= 'f')
            {
                UnderlyingBuffer.Replace(i, 1, ((char)(character + difference)).ToString());
            }
        }
    }

    private static IEditableBuffer GetBufferFromValue(BigInteger value)
    {
        return GetBufferFromValue(value, IReadOnlyIntegerLiteral.Base.Decimal,
            new IntegerLiteralFormatting(3, int.MaxValue, IIntegerLiteralFormatting.Endianness.Little,
                IIntegerLiteralFormatting.HexadecimalMode.Uppercase));
    }

    private static IEditableBuffer GetBufferFromValue(BigInteger value, IReadOnlyIntegerLiteral.Base @base)
    {
        return GetBufferFromValue(value, @base,
            new IntegerLiteralFormatting(3, int.MaxValue, IIntegerLiteralFormatting.Endianness.Little,
                IIntegerLiteralFormatting.HexadecimalMode.Uppercase));
    }

    private static IEditableBuffer GetBufferFromValue(BigInteger value, IIntegerLiteralFormatting formatting)
    {
        return GetBufferFromValue(value, IReadOnlyIntegerLiteral.Base.Decimal, formatting);
    }

    private static IEditableBuffer GetBufferFromValue(BigInteger value, IReadOnlyIntegerLiteral.Base @base,
        IIntegerLiteralFormatting formatting)
    {
        IEditableBuffer buffer = new EditableBuffer();

        ChangeBufferWithValue(buffer, value, @base, formatting);
        return buffer;
    }

    private static void ChangeBufferWithValue(IEditableBuffer buffer, BigInteger value,
        IReadOnlyIntegerLiteral.Base @base,
        IIntegerLiteralFormatting formatting)
    {
        buffer.Remove(0, buffer.Length);
        buffer.Insert(0, @base.BasePrefix());
        if (value == BigInteger.Zero)
        {
            buffer.Insert(0, "0");
            return;
        }

        BigInteger radix = @base.BaseRadix();
        BigInteger valueCopy = value;
        int numberOfRequiredDigits = 0;

        while (valueCopy > 0)
        {
            numberOfRequiredDigits += 1;
            valueCopy /= radix;
        }


        switch (formatting.CurrentEndianness)
        {
            case IIntegerLiteralFormatting.Endianness.Center:
                InsertBufferForValueFormattedCenter(buffer, value, formatting, radix, numberOfRequiredDigits,
                    @base.BaseValueToCharFunction(formatting.CurrentHexadecimalMode));
                return;
            case IIntegerLiteralFormatting.Endianness.Big:
                InsertBufferForValueFormattedBigEndian(buffer, value, formatting, numberOfRequiredDigits, radix,
                    @base.BaseValueToCharFunction(formatting.CurrentHexadecimalMode));
                return;
            case IIntegerLiteralFormatting.Endianness.Little:
                InsertBufferForValueFormattedLittleEndian(buffer, value, formatting, numberOfRequiredDigits, radix,
                    @base.BaseValueToCharFunction(formatting.CurrentHexadecimalMode));
                return;
            default:
                InsertBufferForValueNoFormatting(buffer, value, radix,
                    @base.BaseValueToCharFunction(formatting.CurrentHexadecimalMode));
                return;
        }
    }

    private void DeduceAttributesWithoutFormatting()
    {
        if (Buffer.Length == 1)
        {
            CurrentBase = IReadOnlyIntegerLiteral.Base.Decimal;
            CurrentFormatting = IntegerLiteralFormatting.CurrentDefaultForBase(IReadOnlyIntegerLiteral.Base.Decimal);
            return;
        }

        char secondChar = Buffer[1];

        (CurrentBase, ValueStart) = secondChar switch
        {
            'b' => (IReadOnlyIntegerLiteral.Base.Binary, 2),
            'o' => (IReadOnlyIntegerLiteral.Base.Octal, 2),
            'x' => (IReadOnlyIntegerLiteral.Base.Hexadecimal, 2),
            _ => (IReadOnlyIntegerLiteral.Base.Decimal, 0)
        };
    }

    private void DeduceAttributes()
    {
        DeduceAttributesWithoutFormatting();

        CurrentFormatting = DeduceFormatting();
    }

    protected override IReadOnlyPrimitiveLiteralTypeResolutionContext ProvidePrimitiveLiteralTypeResolutionContext()
    {
        return _primitiveLiteralTypeResolutionContext;
    }
}