using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelectorExpressions;

public interface IReadOnlyExplicitGetterSelectorExpression : IReadOnlySelectorExpression
{
    IReadOnlyIdentifier GetterArgumentLabel { get; }
    
    Colon GetterArgumentLabelValueSeparator { get; }
    
    IReadOnlyExpression GetterArgumentValue { get; }
}
