using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SuperClassExpressions;

public interface IReadOnlySuperClassMethodExpression : IReadOnlySuperClassExpression
{
    Period Period { get; }
    
    IReadOnlyIdentifier MethodName { get; }
}
