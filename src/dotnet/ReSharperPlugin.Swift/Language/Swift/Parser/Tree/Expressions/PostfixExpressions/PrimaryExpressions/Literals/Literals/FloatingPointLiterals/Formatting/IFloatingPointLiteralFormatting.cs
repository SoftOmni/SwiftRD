using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.IntegerLiterals.Formatting;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.Literals.FloatingPointLiterals.Formatting;

public interface IFloatingPointLiteralFormatting
{
    enum Casing
    {
        Uppercase,
        Lowercase
    }

    enum Explicitness
    {
        Implicit,
        Explicit
    }
    
    IIntegerLiteralFormatting IntegralPartFormatting { get; }
    
    IIntegerLiteralFormatting DecimalPartFormatting { get; }
    
    IIntegerLiteralFormatting ExponentPartFormatting { get; }
    
    Casing ExponentCasing { get; }
    
    Explicitness SignExplicitness { get; }
}
