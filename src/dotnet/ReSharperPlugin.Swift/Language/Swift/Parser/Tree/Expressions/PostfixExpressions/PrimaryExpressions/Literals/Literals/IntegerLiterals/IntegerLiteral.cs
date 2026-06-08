using System.Numerics;
using JetBrains.DocumentModel.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals.Formatting;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.
    Literals.IntegerLiterals;

public partial class IntegerLiteral : Literal<Int, BigInteger>, IIntegerLiteral
{
    public IntegerLiteral(BigInteger value)
        : base(GetBufferFromValue(value), Int.Instance, value)
    {
        CurrentFormatting = IntegerLiteralFormatting.CurrentDefaultForBase(IReadOnlyIntegerLiteral.Base.Decimal);
        DeduceAttributes();
    }

    public IntegerLiteral(BigInteger value, IReadOnlyIntegerLiteral.Base @base)
        : base(GetBufferFromValue(value, @base), Int.Instance, value)
    {
        CurrentFormatting = IntegerLiteralFormatting.CurrentDefaultForBase(@base);
        DeduceAttributes();
    }

    public IntegerLiteral(BigInteger value, IIntegerLiteralFormatting formatting)
        : base(GetBufferFromValue(value, formatting), Int.Instance, value)
    {
        CurrentFormatting = IntegerLiteralFormatting.CurrentDefaultForBase(IReadOnlyIntegerLiteral.Base.Decimal);
        DeduceAttributes();
    }

    public IntegerLiteral(BigInteger value, IReadOnlyIntegerLiteral.Base @base,
        IIntegerLiteralFormatting formatting)
        : base(GetBufferFromValue(value, @base, formatting), Int.Instance, value)
    {
        CurrentFormatting = IntegerLiteralFormatting.CurrentDefaultForBase(@base);
        DeduceAttributes();
    }

    internal IntegerLiteral(IEditableBuffer underlyingBuffer, BigInteger value)
        : base(underlyingBuffer, Int.Instance, value)
    {
        DeduceAttributesWithoutFormatting();
        CurrentFormatting = DeduceFormatting();
    }

    internal IntegerLiteral(IEditableBuffer underlyingBuffer, BigInteger value,
        IReadOnlyIntegerLiteral.Base @base, IIntegerLiteralFormatting? strategy = null,
        IIntegerLiteralFormatting.HexadecimalMode? hexadecimalMode = null)
        : base(underlyingBuffer, Int.Instance, value)
    {
        CurrentBase = @base;
        CurrentFormatting = strategy ?? DeduceFormatting();
        CurrentHexadecimalMode = hexadecimalMode;
    }

    internal IntegerLiteral(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex,
        int parentTextIndex, BigInteger value)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex, Int.Instance, value)
    {
        DeduceAttributesWithoutFormatting();
        CurrentFormatting = DeduceFormatting();
    }

    internal IntegerLiteral(IEditableBuffer underlyingBuffer, SwiftCompositeNode parentNode, int parentIndex,
        int parentTextIndex, BigInteger value, IReadOnlyIntegerLiteral.Base @base,
        IIntegerLiteralFormatting? strategy = null, IIntegerLiteralFormatting.HexadecimalMode? hexadecimalMode = null)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex, Int.Instance, value)
    {
        CurrentBase = @base;
        CurrentFormatting = strategy ?? DeduceFormatting();
        CurrentHexadecimalMode = hexadecimalMode;
    }

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
            new IntegerLiteralFormatting(3, int.MaxValue, IIntegerLiteralFormatting.Endianness.Little, IIntegerLiteralFormatting.HexadecimalMode.Uppercase));
    }

    private static IEditableBuffer GetBufferFromValue(BigInteger value, IReadOnlyIntegerLiteral.Base @base)
    {
        return GetBufferFromValue(value, @base,
            new IntegerLiteralFormatting(3, int.MaxValue, IIntegerLiteralFormatting.Endianness.Little, IIntegerLiteralFormatting.HexadecimalMode.Uppercase));
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
                InsertBufferForValueFormattedCenter(buffer, value, formatting, radix, numberOfRequiredDigits, @base.BaseValueToCharFunction(formatting.CurrentHexadecimalMode));
                return;
            case IIntegerLiteralFormatting.Endianness.Big:
                InsertBufferForValueFormattedBigEndian(buffer, value, formatting, numberOfRequiredDigits, radix, @base.BaseValueToCharFunction(formatting.CurrentHexadecimalMode));
                return;
            case IIntegerLiteralFormatting.Endianness.Little:
                InsertBufferForValueFormattedLittleEndian(buffer, value, formatting, numberOfRequiredDigits, radix, @base.BaseValueToCharFunction(formatting.CurrentHexadecimalMode));
                return;
            default:
                InsertBufferForValueNoFormatting(buffer, value, radix, @base.BaseValueToCharFunction(formatting.CurrentHexadecimalMode));
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
}