using System;
using System.Numerics;
using ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals.Formatting;
using SoftOmni.SwiftRd.Language.Semantics.Type.BuiltinTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;

public interface IReadOnlyIntegerLiteral : IReadOnlyLiteral<Int, BigInteger>
{
    public enum Base
    {
        Binary,
        Octal,
        Decimal,
        Hexadecimal
    }
    
    Base CurrentBase { get; }
    
    IIntegerLiteralFormatting CurrentFormatting { get; }
    
    IIntegerLiteralFormatting.HexadecimalMode? CurrentHexadecimalMode { get; }
}

public static class BaseExtensions
{
    public static string BasePrefix(this IReadOnlyIntegerLiteral.Base @base)
    {
        return @base switch
        {
            IReadOnlyIntegerLiteral.Base.Binary => "0b",
            IReadOnlyIntegerLiteral.Base.Octal => "0o",
            IReadOnlyIntegerLiteral.Base.Decimal => "",
            IReadOnlyIntegerLiteral.Base.Hexadecimal => "0x",
            _ => throw new ArgumentOutOfRangeException(nameof(@base))
        };
    }
    
    public static int BaseRadix(this IReadOnlyIntegerLiteral.Base @base)
    {
        return @base switch
        {
            IReadOnlyIntegerLiteral.Base.Binary => 2,
            IReadOnlyIntegerLiteral.Base.Octal => 8,
            IReadOnlyIntegerLiteral.Base.Decimal => 10,
            IReadOnlyIntegerLiteral.Base.Hexadecimal => 16,
            _ => throw new ArgumentOutOfRangeException(nameof(@base))
        };
    }
    
    public static Func<BigInteger, string> BaseValueToCharFunction(this IReadOnlyIntegerLiteral.Base @base, IIntegerLiteralFormatting.HexadecimalMode hexadecimalMode)
    {
        return @base switch
        {
            IReadOnlyIntegerLiteral.Base.Binary => value => ('0' + value % @base.BaseRadix()).ToString(),
            IReadOnlyIntegerLiteral.Base.Octal => value => ('0' + value % @base.BaseRadix()).ToString(),
            IReadOnlyIntegerLiteral.Base.Decimal => value => ('0' + value % @base.BaseRadix()).ToString(),
            IReadOnlyIntegerLiteral.Base.Hexadecimal => value => ((int)(value % @base.BaseRadix())) switch
            {
                0 => "0",
                1 => "1",
                2 => "2",
                3 => "3",
                4 => "4",
                5 => "5",
                6 => "6",
                7 => "7",
                8 => "8",
                9 => "9",
                10 => hexadecimalMode switch
                {
                    IIntegerLiteralFormatting.HexadecimalMode.Lowercase => "a",
                    _ => "A",
                },
                11 => hexadecimalMode switch
                {
                    IIntegerLiteralFormatting.HexadecimalMode.Lowercase => "b",
                    _ => "B",
                },
                12 => hexadecimalMode switch
                {
                    IIntegerLiteralFormatting.HexadecimalMode.Lowercase => "c",
                    _ => "C",
                },
                13 => hexadecimalMode switch
                {
                    IIntegerLiteralFormatting.HexadecimalMode.Lowercase => "d",
                    _ => "D",
                },
                14 => hexadecimalMode switch
                {
                    IIntegerLiteralFormatting.HexadecimalMode.Lowercase => "e",
                    _ => "E",
                },
                15 => hexadecimalMode switch
                {
                    IIntegerLiteralFormatting.HexadecimalMode.Lowercase => "f",
                    _ => "F",
                },
                _ => "0"
            },
            _ => throw new ArgumentOutOfRangeException(nameof(@base))
        };
    }
}