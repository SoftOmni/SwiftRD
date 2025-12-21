using System;
using System.Numerics;
using ExtendedNumerics;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Errors;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Literals;
using ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes;
using Double = ReSharperPlugin.Swift.Language.Semantics.Type.BuiltinTypes.Double;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer;

public partial class SwiftLexer
{
    private void LexNumberLiteral()
    {
        const char zeroChar = '0';
        const string zeroString = "0";

        const char binaryPrefix = 'b';
        const char octalPrefix = 'o';
        const char hexadecimalPrefix = 'x';

        TokenStart = TokenEnd;

        if (Buffer[TokenStart] != zeroChar)
        {
            LexDecimalNumberLiteral();
            return;
        }

        TokenEnd++;
        if (TokenEnd == EOFPos)
        {
            TokenType = SwiftTokens.IntegerLiteralToken;

            IntegerBackingLiteralToken<Int> backingLiteralToken = new(
                Int.Instance, BigInteger.Zero, zeroString);
            BackPutBackingToken(backingLiteralToken);
            return;
        }

        char directorCharacter = Buffer[TokenEnd];
        TokenEnd++;

        switch (directorCharacter)
        {
            case binaryPrefix:
                LexBinary();
                return;
            case octalPrefix:
                LexOctal();
                return;
            case hexadecimalPrefix:
                LexHexadecimalNumberLiteral();
                return;
            case '0':
            case '1':
            case '2':
            case '3':
            case '4':
            case '5':
            case '6':
            case '7':
            case '8':
            case '9':
                TokenEnd = TokenStart;
                LexDecimalNumberLiteral();
                return;
            default:
                TokenEnd = TokenStart + 1;
                TokenType = SwiftTokens.IntegerLiteralToken;

                IntegerBackingLiteralToken<Int> integerBackingLiteralToken = new(
                    Int.Instance, BigInteger.Zero, zeroString);
                BackPutBackingToken(integerBackingLiteralToken);
                return;
        }
    }

    private void LexDecimalNumberLiteral()
    {
        LexUndecidedNumberLiteral(new BigInteger(10), c => c.IsDecimalLiteralCharacter(),
            c => c.ConvertDecimalCharToValue(), c => c.IsFloatingPointE(),
            (value, valueString) => new IntegerBackingLiteralToken<Int>(Int.Instance, value, valueString),
            c => c.ConvertDecimalCharToValue(), DecimalExponentiation, new BigInteger(10), new BigDecimal(0.1),
            SwiftTokens.IntegerLiteralToken, FloatingPointRepresentation.Decimal,
            BackingErroneousFloatingPointLiteralToken<Double>.ErrorCase.DecimalPartMissingDecimal,
            BackingErroneousFloatingPointLiteralToken<Double>.ErrorCase.ExponentValueMissingDecimal);
        return;

        BigDecimal DecimalExponentiation(BigDecimal value, BigInteger exponentValue, bool isNegative)
        {
            if (isNegative)
                exponentValue = -exponentValue;

            value = BigDecimal.Pow(value, exponentValue);
            return value;
        }
    }

    private void LexHexadecimalNumberLiteral()
    {
        LexUndecidedNumberLiteral(new BigInteger(16), c => c.IsHexadecimalLiteralCharacter(),
            c => c.ConvertHexadecimalCharToValue(), c => c.IsFloatingPointP(),
            (value, valueString) => new IntegerBackingLiteralToken<Int>(Int.Instance, value, valueString,
                IntegerRepresentation.Hexadecimal), c => c.ConvertDecimalCharToValue(),
            HexadecimalExponentiation, new BigInteger(10), new BigDecimal(0.0625),
            SwiftTokens.IntegerLiteralToken,
            FloatingPointRepresentation.Hexadecimal,
            BackingErroneousFloatingPointLiteralToken<Double>.ErrorCase.DecimalPartMissingHexadecimal,
            BackingErroneousFloatingPointLiteralToken<Double>.ErrorCase.ExponentValueMissingHexadecimal);
        return;

        BigDecimal HexadecimalExponentiation(BigDecimal value, BigInteger exponentValue, bool isNegative)
        {
            BigDecimal exponent = isNegative
                ? BigDecimal.Pow(new BigDecimal(2), -exponentValue)
                : BigDecimal.Pow(new BigDecimal(2), exponentValue);

            return value * exponent;
        }
    }

    private void LexBinary()
    {
        LexUndecidedIntegerLiteral(2, c => c.IsBinaryLiteralCharacter(),
            c => c.ConvertBinaryCharToValue(),
            (value, valueAsString) =>
                new IntegerBackingLiteralToken<Int>(Int.Instance, value, valueAsString, IntegerRepresentation.Binary));
    }

    private void LexOctal()
    {
        LexUndecidedIntegerLiteral(8, c => c.IsOctalLiteralCharacter(),
            c => c.ConvertOctalCharToValue(),
            (value, valueAsString) =>
                new IntegerBackingLiteralToken<Int>(Int.Instance, value, valueAsString, IntegerRepresentation.Binary));
    }

    // ReSharper disable once CognitiveComplexity
    private void LexFloatingPoint(BigInteger mainValue, Func<char, bool> isDigit,
        Func<char, bool> isExponent, Func<char, int> digitValueBase, Func<char, int> digitValueExponent,
        Func<BigDecimal, BigInteger, bool, BigDecimal> exponentiation,
        BigInteger exponentRadix,
        BigDecimal fractionalPartMultiplier,
        FloatingPointRepresentation representation,
        BackingErroneousFloatingPointLiteralToken<Double>.ErrorCase decimalPartMissing,
        BackingErroneousFloatingPointLiteralToken<Double>.ErrorCase exponentValueMissing)
    {
        BigDecimal value = new(mainValue);

        if (Buffer[TokenEnd] == Dot)
        {
            TokenEnd++;
        }

        if (TokenEnd == EOFPos || !isDigit(Buffer[TokenEnd]))
        {
            string valueAsString = GetCurrentText();
            TokenType = SwiftTokens.ErroneousFloatingPointLiteralToken;

            BackingErroneousFloatingPointLiteralToken<Double> backingErroneousFloatingPointLiteralToken =
                new(decimalPartMissing, Double.Instance, value, valueAsString, representation);
            BackPutBackingToken(backingErroneousFloatingPointLiteralToken);
            return;
        }

        BigDecimal fractionalPart = new(BigInteger.Zero);
        BigDecimal currentMultiplier = fractionalPartMultiplier;

        TokenEnd++;
        while (TokenEnd < EOFPos && isDigit(Buffer[TokenEnd]))
        {
            if (Buffer[TokenEnd] != Underscore)
            {
                fractionalPart += digitValueBase(Buffer[TokenEnd]) * currentMultiplier;
                currentMultiplier *= fractionalPartMultiplier;
            }

            TokenEnd++;
        }

        value += fractionalPart;
        if (TokenEnd == EOFPos || !isExponent(Buffer[TokenEnd]))
        {
            string valueAsString = GetCurrentText();
            TokenType = SwiftTokens.FloatingPointLiteralToken;

            FloatingPointLiteralTokenBaker<Double> floatingPointLiteralTokenBakerDirect =
                new(Double.Instance, value, valueAsString);

            BackPutBackingToken(floatingPointLiteralTokenBakerDirect);
            return;
        }

        TokenEnd++;
        if (TokenEnd == EOFPos)
        {
            string valueAsString = GetCurrentText();

            TokenType = SwiftTokens.ErroneousFloatingPointLiteralToken;
            BackingErroneousFloatingPointLiteralToken<Double> erroneousFloatingPointLiteralToken =
                new(exponentValueMissing, Double.Instance, value, valueAsString, representation);

            BackPutBackingToken(erroneousFloatingPointLiteralToken);
            return;
        }

        bool isNegative = Buffer[TokenEnd] == Dash;
        if (Buffer[TokenEnd] == Plus || Buffer[TokenEnd] == Dash)
        {
            TokenEnd++;
        }

        if (TokenEnd == EOFPos || (!isDigit(Buffer[TokenEnd]) && Buffer[TokenEnd] != Underscore))
        {
            string valueAsString = GetCurrentText();

            TokenType = SwiftTokens.ErroneousFloatingPointLiteralToken;
            BackingErroneousFloatingPointLiteralToken<Double> backingErroneousFloatingPointLiteralToken =
                new(
                    exponentValueMissing,
                    Double.Instance,
                    value, valueAsString, representation);

            BackPutBackingToken(backingErroneousFloatingPointLiteralToken);
            return;
        }

        TokenEnd++;
        BigInteger exponentValue = BigInteger.Zero;

        while (TokenEnd < EOFPos && !isDigit(Buffer[TokenEnd]))
        {
            if (Buffer[TokenEnd] != Underscore)
            {
                exponentValue += digitValueExponent(Buffer[TokenEnd]);
                exponentValue *= exponentRadix;
            }
        }

        string fullValue = GetCurrentText();
        value = exponentiation(value, exponentValue, isNegative);
        TokenType = SwiftTokens.FloatingPointLiteralToken;
        
        FloatingPointLiteralTokenBaker<Double> floatingPointLiteralTokenBaker = new(Double.Instance,
            value, fullValue);
        BackPutBackingToken(floatingPointLiteralTokenBaker);
    }

    private void LexUndecidedIntegerLiteral(int radix, Func<char, bool> isDigit, Func<char, int> digitValue,
        Func<BigInteger, string, IntegerBackingLiteralToken<Int>> backerTypeFactory)
    {
        BigInteger value = BigInteger.Zero;

        while (TokenEnd < EOFPos && isDigit(Buffer[TokenEnd]))
        {
            if (Buffer[TokenEnd] != Underscore)
            {
                value *= radix;
                value += digitValue(Buffer[TokenEnd]);
            }

            TokenEnd++;
        }

        string valueString = GetCurrentText();

        TokenType = SwiftTokens.IntegerLiteralToken;
        IntegerBackingLiteralToken<Int> backingLiteralToken = backerTypeFactory(value, valueString);
        BackPutBackingToken(backingLiteralToken);
    }

    private void LexUndecidedNumberLiteral(BigInteger radix, Func<char, bool> isDigit,
        Func<char, int> digitValue, Func<char, bool> isExponent,
        Func<BigInteger, string, BackerToken> backerTokenFactory, Func<char, int> digitValueExponent,
        Func<BigDecimal, BigInteger, bool, BigDecimal> exponentiation,
        BigInteger exponentRadix,
        BigDecimal fractionalPartMultiplier,
        SwiftTokenNodeType integerTokenType,
        FloatingPointRepresentation representation,
        BackingErroneousFloatingPointLiteralToken<Double>.ErrorCase decimalPartMissing,
        BackingErroneousFloatingPointLiteralToken<Double>.ErrorCase exponentValueMissing)
    {
        BigInteger value = BigInteger.Zero;

        while (TokenEnd < EOFPos && isDigit(Buffer[TokenEnd]))
        {
            if (Buffer[TokenEnd] != Underscore)
            {
                value *= radix;
                value += digitValue(Buffer[TokenEnd]);
            }

            TokenEnd++;
        }

        string valueString = GetCurrentText();
        if (TokenEnd == EOFPos)
        {
            TokenType = integerTokenType;
            BackerToken backerTokenImmediate = backerTokenFactory(value, valueString);

            BackPutBackingToken(backerTokenImmediate);
            return;
        }

        if (Buffer[TokenEnd] == Dot || isExponent(Buffer[TokenEnd]))
        {
            LexFloatingPoint(value, isDigit, isExponent, digitValue, digitValueExponent, exponentiation, exponentRadix,
                fractionalPartMultiplier, representation, decimalPartMissing, exponentValueMissing);
        }

        TokenType = integerTokenType;
        BackerToken backerToken = backerTokenFactory(value, valueString);

        BackPutBackingToken(backerToken);
    }
}

internal static partial class SwiftLexerExtensions
{
    public static bool IsBinaryLiteralCharacter(this char c)
    {
        return c is '0' or '1' or SwiftLexer.Underscore;
    }

    public static bool IsOctalLiteralCharacter(this char c)
    {
        return c.IsBinaryLiteralCharacter() || c is '2' or '3' or '4' or '5' or '6' or '7';
    }

    public static bool IsDecimalLiteralCharacter(this char c)
    {
        return c.IsOctalLiteralCharacter() || c is '8' or '9';
    }

    public static bool IsHexadecimalLiteralCharacter(this char c)
    {
        return c.IsDecimalLiteralCharacter() ||
               c is 'a' or 'b' or 'c' or 'd' or 'e' or 'f' or 'A' or 'B' or 'C' or 'D' or 'E' or 'F';
    }

    public static bool IsFloatingPointE(this char c)
    {
        const char eLowercase = 'e';
        const char eUppercase = 'E';

        return c is eLowercase or eUppercase;
    }

    public static bool IsFloatingPointP(this char c)
    {
        const char pLowercase = 'p';
        const char pUppercase = 'P';

        return c is pLowercase or pUppercase;
    }

    public static int ConvertBinaryCharToValue(this char c)
    {
        return c - '0';
    }

    public static int ConvertOctalCharToValue(this char c)
    {
        return c - '0';
    }

    public static int ConvertDecimalCharToValue(this char c)
    {
        return c - '0';
    }

    public static int ConvertHexadecimalCharToValue(this char c)
    {
        return c switch
        {
            <= '9' => c - '0',
            <= 'F' => c - 'A' + 10,
            <= 'f' => c - 'a' + 10,
            _ => throw new ArgumentOutOfRangeException(nameof(c), c, "Invalid hexadecimal character")
        };
    }
}