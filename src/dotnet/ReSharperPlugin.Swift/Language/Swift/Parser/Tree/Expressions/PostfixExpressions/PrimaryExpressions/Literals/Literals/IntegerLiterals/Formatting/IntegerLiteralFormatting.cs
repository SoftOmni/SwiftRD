using System;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals.Formatting;

public struct IntegerLiteralFormatting(
    int spacingAmount,
    int fillupThreshold,
    IIntegerLiteralFormatting.Endianness endianness,
    IIntegerLiteralFormatting.HexadecimalMode hexadecimalMode
)
    : IIntegerLiteralFormatting, IEquatable<IIntegerLiteralFormatting>
{
    public IntegerLiteralFormatting(int spacingAmount, int fillupThreshold, int outerSpacingAmount,
        IIntegerLiteralFormatting.Endianness endianness, IIntegerLiteralFormatting.HexadecimalMode hexadecimalMode)
        : this(spacingAmount, fillupThreshold, endianness, hexadecimalMode)
    {
        OuterSpacing = outerSpacingAmount;
    }

    public int OuterSpacing { get; } = spacingAmount;

    public int SpacingAmount { get; } = spacingAmount;

    public int FillupThreshold { get; } = fillupThreshold;

    public IIntegerLiteralFormatting.Endianness CurrentEndianness { get; } = endianness;

    public IIntegerLiteralFormatting.HexadecimalMode CurrentHexadecimalMode { get; } = hexadecimalMode;

    public bool Equals(IIntegerLiteralFormatting other)
    {
        return SpacingAmount == other.SpacingAmount && OuterSpacing == other.OuterSpacing &&
               FillupThreshold == other.FillupThreshold;
    }

    private static readonly IntegerLiteralFormatting AbsoluteDefaultBinary = new(4, int.MaxValue,
        IIntegerLiteralFormatting.Endianness.Little, IIntegerLiteralFormatting.HexadecimalMode.Uppercase);

    private static readonly IntegerLiteralFormatting AbsoluteDefaultOctal = new(3, int.MaxValue,
        IIntegerLiteralFormatting.Endianness.Little, IIntegerLiteralFormatting.HexadecimalMode.Uppercase);

    private static readonly IntegerLiteralFormatting AbsoluteDefaultDecimal = new(3, int.MaxValue,
        IIntegerLiteralFormatting.Endianness.Little, IIntegerLiteralFormatting.HexadecimalMode.Uppercase);

    private static readonly IntegerLiteralFormatting AbsoluteDefaultHexadecimal = new(4, int.MaxValue,
        IIntegerLiteralFormatting.Endianness.Little, IIntegerLiteralFormatting.HexadecimalMode.Uppercase);

    public static IntegerLiteralFormatting CurrentStoredDefaultBinary { get; set; } = AbsoluteDefaultBinary;

    public static IntegerLiteralFormatting CurrentStoredDefaultOctal { get; set; } = AbsoluteDefaultOctal;

    public static IntegerLiteralFormatting CurrentStoredDefaultDecimal { get; set; } = AbsoluteDefaultDecimal;

    public static IntegerLiteralFormatting CurrentStoredDefaultHexadecimal { get; set; } = AbsoluteDefaultHexadecimal;


    public static IIntegerLiteralFormatting CurrentDefaultForBase(IReadOnlyIntegerLiteral.Base @base)
    {
        return @base switch
        {
            IReadOnlyIntegerLiteral.Base.Binary => CurrentStoredDefaultBinary,
            IReadOnlyIntegerLiteral.Base.Octal => CurrentStoredDefaultOctal,
            IReadOnlyIntegerLiteral.Base.Decimal => CurrentStoredDefaultDecimal,
            IReadOnlyIntegerLiteral.Base.Hexadecimal => CurrentStoredDefaultHexadecimal,
            _ => throw new ArgumentOutOfRangeException(nameof(@base), @base, null)
        };
    }
}