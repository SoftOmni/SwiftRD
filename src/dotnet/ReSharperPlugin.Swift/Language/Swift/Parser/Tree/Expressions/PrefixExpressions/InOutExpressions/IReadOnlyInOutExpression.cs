using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PrefixExpressions.InOutExpressions;

public interface IReadOnlyInOutExpression : IReadOnlyPrefixExpression
{
    Ampersand Ampersand { get; }
    
    IReadOnlyPrimaryExpression PrimaryExpression { get; }
}