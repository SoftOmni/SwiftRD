using System;
using System.Numerics;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals.Formatting;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals;

public partial class FloatingPointLiteral
{
    private void DetermineCharacteristics()
    {
        DetermineCharacteristicsWithoutFormatting();

        IFloatingPointLiteralFormatting.Casing exponentCasing;
        if (!HasExponentPart)
        {
            exponentCasing = FloatingPointLiteralFormatting.CurrentStoredDefaultCasing;
        }
        else if (Buffer[ExponentIndex] is 'p' or 'e')
        {
            exponentCasing = IFloatingPointLiteralFormatting.Casing.Lowercase;
        }
        else
        {
            exponentCasing = IFloatingPointLiteralFormatting.Casing.Uppercase;
        }

        IFloatingPointLiteralFormatting.Explicitness signExplicitness;
        if (!HasExponentPart)
        {
            signExplicitness = FloatingPointLiteralFormatting.CurrentStoredDefaultSignExplicitness;
        }
        else
        {
            signExplicitness = Buffer[ExponentIndex + 1] is '+' or '-'
                ? IFloatingPointLiteralFormatting.Explicitness.Explicit
                : IFloatingPointLiteralFormatting.Explicitness.Implicit;
        }

        Formatting = new FloatingPointLiteralFormatting(
            IntegralPartDetachedValue.CurrentFormatting,
            DecimalPartDetachedValue.CurrentFormatting,
            ExponentValueDetachedValue.CurrentFormatting,
            exponentCasing,
            signExplicitness
        );
    }
    
    private void DetermineCharacteristicsWithoutFormatting()
    {
        int index = 0;

        IntegralPartDetachedValue = EatDecimalPart(ref index, (character, characterIndex) =>
        {
            if (character != '.')
            {
                return false;
            }

            DecimalSeparatorIndex = characterIndex;
            return true;
        });

        IntegralPartValue = IntegralPartDetachedValue.Value;
        index++;

        if (index == Buffer.Length)
        {
            return;
        }

        DecimalPartDetachedValue = EatDecimalPart(ref index, (character, characterIndex) =>
        {
            if (character is not 'E' and not 'e' and not 'P' and not 'p')
            {
                return false;
            }

            ExponentIndex = characterIndex;
            return true;
        });

        DecimalPartValue = DecimalPartDetachedValue.Value;
        index++;

        if (index == Buffer.Length)
        {
            return;
        }

        if (Buffer[index] is '-')
        {
            ExponentSign = IReadOnlyFloatingPointLiteral.Sign.Negative;
            index++;
        }
        else if (Buffer[index] is '+')
        {
            ExponentSign = IReadOnlyFloatingPointLiteral.Sign.Positive;
            index++;
        }
        else
        {
            ExponentSign = IReadOnlyFloatingPointLiteral.Sign.Positive;
        }

        ExponentValueDetachedValue = EatDecimalPart(ref index, (_, _) => false);
        ExponentValue = ExponentValueDetachedValue.Value;

        Base = IntegralPartDetachedValue.CurrentBase is IReadOnlyIntegerLiteral.Base.Decimal
            ? IReadOnlyFloatingPointLiteral.Base.Decimal
            : IReadOnlyFloatingPointLiteral.Base.Hexadecimal;
    }

    private IIntegerLiteral EatDecimalPart(ref int index, Func<char, int, bool> specialMarkerSpotter)
    {
        BigInteger value = BigInteger.Zero;

        int startIndex = index;
        while (index < Buffer.Length)
        {
            if (specialMarkerSpotter(Buffer[index], index))
            {
                break;
            }

            if (Buffer[index] == '_')
            {
                index++;
                continue;
            }
            
            value *= new BigInteger(10);
            value += Buffer[index].ConvertHexadecimalCharToValue();
            index++;
        }

        IEditableBuffer subIntegralBuffer = new SubEditableBuffer(UnderlyingBuffer, index, index - startIndex);
        IntegerLiteral integerLiteral = new(subIntegralBuffer, value, _primitiveLiteralTypeResolutionContext);

        return integerLiteral;
    }
}