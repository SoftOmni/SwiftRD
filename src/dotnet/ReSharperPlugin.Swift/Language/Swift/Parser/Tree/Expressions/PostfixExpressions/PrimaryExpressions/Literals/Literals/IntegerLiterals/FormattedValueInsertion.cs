using System;
using System.Numerics;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals.Formatting;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;

public partial class IntegerLiteral
{
    private static void InsertBufferForValueFormattedCenter(IEditableBuffer buffer, BigInteger value,
        IIntegerLiteralFormatting formatting, BigInteger radix, int numberOfRequiredDigits,
        Func<BigInteger, string> valueCharacterBaseConverter)
    {
        int insertionLocation = buffer.Length;
        for (int startTextIndex = 0; startTextIndex < formatting.OuterSpacing; startTextIndex++)
        {
            buffer.Insert(insertionLocation, valueCharacterBaseConverter(value % radix));
            value /= radix;
        }

        int sections = (numberOfRequiredDigits - formatting.OuterSpacing * 2) / formatting.SpacingAmount;
        int centerSectionDigits = (numberOfRequiredDigits - formatting.OuterSpacing * 2) % formatting.SpacingAmount;
            
        for (int sectionIndex = 0; sectionIndex < sections / 2; sectionIndex++)
        {
            buffer.Insert(insertionLocation, "_");
            for (int sectionTextIndex = 0; sectionTextIndex < formatting.SpacingAmount; sectionTextIndex++)
            {
                buffer.Insert(insertionLocation, valueCharacterBaseConverter(value % radix));
                value /= radix;
            }
        }

        if (sections % 2 == 1)
        {
            centerSectionDigits += formatting.SpacingAmount;
        }

        if (centerSectionDigits > 0)
        {
            buffer.Insert(insertionLocation, "_");
        }
            
        for (int sectionTextIndex = 0; sectionTextIndex < centerSectionDigits; sectionTextIndex++)
        {
            buffer.Insert(insertionLocation, valueCharacterBaseConverter(value % radix));
            value /= radix;
        }
            
        for (int sectionIndex = 0; sectionIndex < sections / 2; sectionIndex++)
        {
            buffer.Insert(insertionLocation, "_");
            for (int sectionTextIndex = 0; sectionTextIndex < formatting.SpacingAmount; sectionTextIndex++)
            {
                buffer.Insert(insertionLocation, valueCharacterBaseConverter(value % radix));
                value /= radix;
            }
        }
    }

    private static void InsertBufferForValueFormattedBigEndian(IEditableBuffer buffer, BigInteger value,
        IIntegerLiteralFormatting formatting, int numberOfRequiredDigits, BigInteger radix,
        Func<BigInteger, string> valueCharacterBaseConverter)
    {
        int insertionLocation = buffer.Length;
        if (numberOfRequiredDigits <= formatting.SpacingAmount)
        {
            for (int onlySectionTextIndex = 0; onlySectionTextIndex < numberOfRequiredDigits; onlySectionTextIndex++)
            {
                buffer.Insert(insertionLocation, valueCharacterBaseConverter(value % radix));
                value /= radix;
            }

            return;
        }

        for (int sectionTextIndex = 0; sectionTextIndex < formatting.SpacingAmount; sectionTextIndex++)
        {
            buffer.Insert(insertionLocation, valueCharacterBaseConverter(value % radix));
            value /= radix;
        }

        int target = numberOfRequiredDigits / formatting.SpacingAmount - 1;
        for (int sectionIndex = 0; sectionIndex < target; sectionIndex++)
        {
            buffer.Insert(insertionLocation, "_");
                
            for (int sectionTextIndex = 0; sectionTextIndex < formatting.SpacingAmount; sectionTextIndex++)
            {
                buffer.Insert(insertionLocation, valueCharacterBaseConverter(value % radix));
                value /= radix;
            }
        }

        if (numberOfRequiredDigits % formatting.SpacingAmount != 0)
        {
            buffer.Insert(insertionLocation, "_");
        }
            
        for (int sectionTextIndex = 0; sectionTextIndex < numberOfRequiredDigits % formatting.SpacingAmount; sectionTextIndex++)
        {
            buffer.Insert(insertionLocation, valueCharacterBaseConverter(value % radix));
            value /= radix;
        }
    }

    private static void InsertBufferForValueFormattedLittleEndian(IEditableBuffer buffer, BigInteger value,
        IIntegerLiteralFormatting formatting, int numberOfRequiredDigits, BigInteger radix,
        Func<BigInteger, string> valueCharacterBaseConverter)
    {
        int insertionLocation = buffer.Length;
            
        for (int sectionTextIndex = 0; sectionTextIndex < numberOfRequiredDigits % formatting.SpacingAmount; sectionTextIndex++)
        {
            buffer.Insert(insertionLocation, valueCharacterBaseConverter(value % radix));
            value /= radix;
        }

        for (int sectionIndex = 0; sectionIndex < numberOfRequiredDigits / formatting.SpacingAmount; sectionIndex++)
        {
            buffer.Insert(insertionLocation, "_");
                
            for (int sectionTextIndex = 0; sectionTextIndex < formatting.SpacingAmount; sectionTextIndex++)
            {
                buffer.Insert(insertionLocation, valueCharacterBaseConverter(value % radix));
                value /= radix;
            }
        }
    }

    private static void InsertBufferForValueNoFormatting(IEditableBuffer buffer, BigInteger value, BigInteger radix,
        Func<BigInteger, string> valueCharacterBaseConverter)
    {
        int insertionLocation = buffer.Length;

        while (value > 0)
        {
            buffer.Insert(insertionLocation, valueCharacterBaseConverter(value % radix));
            value /= radix;
        }
    }
}