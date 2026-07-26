using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals.Formatting;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;

public partial class IntegerLiteral
{
    private IIntegerLiteralFormatting DeduceFormatting()
    {
        int startSpacing = -1;

        int previousSpacing = -1;
        int currentSpacing = 0;

        bool hasMingledSpacing = false;

        bool hexadecimalModeSet = false;
        IIntegerLiteralFormatting.HexadecimalMode? hexadecimalMode = null;
        int digitCount = 0;

        for (int i = ValueStart; i < Buffer.Length; i++)
        {
            char character = Buffer[i];

            if (character.IsHexadecimalLiteralCharacter())
            {
                hexadecimalModeSet = AdjustHexadecimalModeSet(character, hexadecimalModeSet, ref hexadecimalMode);
            }

            if (character != '_' || currentSpacing == -1)
            {
                digitCount += 1;
                currentSpacing += 1;
                continue;
            }

            if (previousSpacing != currentSpacing)
            {
                if (startSpacing == -1)
                {
                    startSpacing = currentSpacing;
                    currentSpacing = 0;
                    continue;
                }

                if (previousSpacing == -1)
                {
                    previousSpacing = currentSpacing;
                    currentSpacing = 0;
                    continue;
                }

                currentSpacing = 0;
                hasMingledSpacing = true;
                continue;
            }

            previousSpacing = currentSpacing;
            currentSpacing = 0;
        }

        return DeduceFormatting(hasMingledSpacing, startSpacing, previousSpacing, currentSpacing, digitCount, hexadecimalMode);
    }

    private IIntegerLiteralFormatting DeduceFormatting(bool hasMingledSpacing, int startSpacing, int previousSpacing, int currentSpacing,
        int digitCount, IIntegerLiteralFormatting.HexadecimalMode? hexadecimalMode)
    {
        int spacingAmount;
        int outerSpacingAmount;
        int fillUpThreshold;
        IIntegerLiteralFormatting.Endianness endianness;

        if (hasMingledSpacing)
        {
            spacingAmount = -5;
            outerSpacingAmount = spacingAmount;
            endianness = IIntegerLiteralFormatting.Endianness.Little;
        }
        else if (startSpacing == currentSpacing)
        {
            /*if (previousSpacing != startSpacing * 2): Not necessary */
            outerSpacingAmount = startSpacing;
            spacingAmount = previousSpacing == -1 ? startSpacing : previousSpacing;
            endianness = IIntegerLiteralFormatting.Endianness.Center;
        }
        else
        {
            if (startSpacing > currentSpacing)
            {
                spacingAmount = startSpacing;
                endianness = IIntegerLiteralFormatting.Endianness.Big;
            }
            else
            {
                spacingAmount = currentSpacing;
                endianness = IIntegerLiteralFormatting.Endianness.Little;
            }

            outerSpacingAmount = spacingAmount;
        }

        switch (CurrentBase)
        {
            case IReadOnlyIntegerLiteral.Base.Octal or IReadOnlyIntegerLiteral.Base.Decimal:
                fillUpThreshold = int.MaxValue;
                break;
            case IReadOnlyIntegerLiteral.Base.Hexadecimal when digitCount == ReturnType.Size / 4:
            case IReadOnlyIntegerLiteral.Base.Binary when digitCount == ReturnType.Size:
                fillUpThreshold = ReturnType.Size;
                break;
            default:
                fillUpThreshold = int.MaxValue;
                break;
        }


        if (spacingAmount == -5)
        {
            return IntegerLiteralFormatting.CurrentDefaultForBase(CurrentBase);
        }

        return new IntegerLiteralFormatting(spacingAmount, fillUpThreshold, outerSpacingAmount, endianness, hexadecimalMode ?? IIntegerLiteralFormatting.HexadecimalMode.Unordered);
    }

    private static bool AdjustHexadecimalModeSet(char character, bool hexadecimalModeSet, ref IIntegerLiteralFormatting.HexadecimalMode? hexadecimalMode)
    {
        if (character is >= 'A' and <= 'F')
        {
            if (hexadecimalModeSet)
            {
                hexadecimalMode = hexadecimalMode switch
                {
                    IIntegerLiteralFormatting.HexadecimalMode.Lowercase => IIntegerLiteralFormatting.HexadecimalMode.Unordered,
                    IIntegerLiteralFormatting.HexadecimalMode.Unordered => IIntegerLiteralFormatting.HexadecimalMode.Unordered,
                    IIntegerLiteralFormatting.HexadecimalMode.Uppercase => IIntegerLiteralFormatting.HexadecimalMode.Uppercase,
                    _ => IIntegerLiteralFormatting.HexadecimalMode.Unordered
                };
            }
            else
            {
                hexadecimalMode = IIntegerLiteralFormatting.HexadecimalMode.Uppercase;
                hexadecimalModeSet = true;
            }
        }
        else
        {
            if (hexadecimalModeSet)
            {
                hexadecimalMode = hexadecimalMode switch
                {
                    IIntegerLiteralFormatting.HexadecimalMode.Lowercase => IIntegerLiteralFormatting.HexadecimalMode.Lowercase,
                    IIntegerLiteralFormatting.HexadecimalMode.Unordered => IIntegerLiteralFormatting.HexadecimalMode.Unordered,
                    IIntegerLiteralFormatting.HexadecimalMode.Uppercase => IIntegerLiteralFormatting.HexadecimalMode.Unordered,
                    _ => IIntegerLiteralFormatting.HexadecimalMode.Unordered // TODO: Log this
                };
            }
            else
            {
                hexadecimalMode = IIntegerLiteralFormatting.HexadecimalMode.Lowercase;
                hexadecimalModeSet = true;
            }
        }

        return hexadecimalModeSet;
    }
}