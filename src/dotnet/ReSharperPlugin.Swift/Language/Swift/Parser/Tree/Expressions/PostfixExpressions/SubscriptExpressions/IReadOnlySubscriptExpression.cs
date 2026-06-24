using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.SubscriptExpressions;

public interface IReadOnlySubscriptExpression : IReadOnlyPostfixExpression, IReadOnlyList<IReadOnlyFunctionCallArgument>
{
    IReadOnlyPostfixExpression PostfixExpression { get; }
    
    LeftSquareBracket LeftSquareBracket { get; }
    
    IReadOnlyList<IReadOnlyFunctionCallArgument> FunctionCallArguments { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    RightSquareBracket RightSquareBracket { get; }
}
