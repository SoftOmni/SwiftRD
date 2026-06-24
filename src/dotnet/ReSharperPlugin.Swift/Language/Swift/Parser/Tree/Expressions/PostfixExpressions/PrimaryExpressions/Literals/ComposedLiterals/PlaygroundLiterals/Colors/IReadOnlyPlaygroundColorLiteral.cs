using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals.
    ComposedLiterals.PlaygroundLiterals.Colors;

public interface IReadOnlyPlaygroundColorLiteral : IReadOnlyPlaygroundLiteral<(IReadOnlyExpression red,
    IReadOnlyExpression green, IReadOnlyExpression blue, IReadOnlyExpression alpha)>
{
    ReservedColorLiteralKeyword ColorLiteralKeyword { get; }

    IReadOnlyFunctionCallExpression CallExpression { get; }
    
    LeftParenthesis LeftArgumentsParenthesis { get; }

    IReadOnlyIdentifier RedArgumentLabel { get; }
    
    Colon RedArgumentLabelValueSeparator { get; }
    
    IReadOnlyExpression RedValue { get; }
    
    Comma RedGreenArgumentSeparator { get; }
    
    IReadOnlyIdentifier GreenArgumentLabel { get; }
    
    Colon GreenArgumentLabelValueSeparator { get; }
    
    IReadOnlyExpression GreenValue { get; }
    
    Comma GreenBlueArgumentSeparator { get; }
    
    IReadOnlyIdentifier BlueArgumentLabel { get; }
    
    Colon BlueArgumentLabelValueSeparator { get; }
    
    IReadOnlyExpression BlueValue { get; }
    
    Comma BlueAlphaArgumentSeparator { get; }
    
    IReadOnlyIdentifier AlphaArgumentLabel { get; }
    
    Colon AlphaArgumentLabelValueSeparator { get; }
    
    IReadOnlyExpression AlphaValue { get; }
    
    RightParenthesis RightArgumentsParenthesis { get; }
}
