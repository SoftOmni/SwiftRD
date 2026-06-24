using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SelfExpressions;

public interface IReadOnlySelfSubscriptExpression : IReadOnlySelfExpression, IReadOnlyList<IReadOnlyFunctionCallArgument>
{
    LeftSquareBracket LeftSquareBracket { get; }
    
    IReadOnlyList<IReadOnlyFunctionCallArgument> Arguments { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    IReadOnlyFunctionCallArgumentList ArgumentList { get; }
    
    RightSquareBracket RightSquareBracket { get; }
}
