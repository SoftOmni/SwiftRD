namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals.Formatting;

public interface IIntegerLiteralFormatting
{
    enum Endianness
    {
        Big,
        Center,
        Little
    }
    
    public enum HexadecimalMode
    {
        Unordered,
        Uppercase,
        Lowercase
    }
    
    int OuterSpacing { get; }
    
    int SpacingAmount { get; }
    
    int FillupThreshold { get; }
    
    Endianness CurrentEndianness { get; }
    
    HexadecimalMode CurrentHexadecimalMode { get; }
}