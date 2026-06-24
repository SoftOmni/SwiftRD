using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;

public interface IReadOnlySelfMethodExpression : IReadOnlySelfExpression
{
    Period Period { get; }
    
    IReadOnlyIdentifier MethodName { get; }
}
