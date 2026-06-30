using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;

public interface IReadOnlyExplicitSetterSelectorExpression : IReadOnlySelectorExpression
{
    IReadOnlyIdentifier SetterArgumentLabel { get; }
    
    Colon SetterArgumentLabelValueSeparator { get; }
    
    IReadOnlyExpression SetterArgumentValue { get; }
}
