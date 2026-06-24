using System;
using ExtendedNumerics;
using JetBrains.DocumentModel.Impl;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals.Formatting;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals;

public partial class FloatingPointLiteral
{
    private static (IIntegerLiteral wholePart, IIntegerLiteral decimalPart, IIntegerLiteral exponent) InsertInBufferFormattedValue(IEditableBuffer buffer, BigDecimal value,
        IFloatingPointLiteralFormatting formatting)
    {
        throw new NotImplementedException();
        IntegerLiteral wholePart = new(value.GetWholePart(), formatting.IntegralPartFormatting);
        buffer.Insert(0, wholePart.GetText());

        BigDecimal decimalPart = value.GetFractionalPart();
        if (decimalPart.IsZero())
        {
            buffer.Insert(buffer.Length, ".");
        }
        
        IEditableBuffer decimalPartBuffer = new EditableBuffer(value.GetFractionalPart().ToString());
        
    }
}