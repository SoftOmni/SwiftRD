using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SuperClassExpressions;

public interface IReadOnlySuperClassSubscriptExpression : IReadOnlySuperClassExpression, IReadOnlyList<IReadOnlyFunctionCallArgument>
{
    LeftSquareBracket LeftSquareBracket { get; }
    
    IReadOnlyList<IReadOnlyFunctionCallArgument> Arguments { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    IReadOnlyFunctionCallArgumentList ArgumentList { get; }
    
    RightSquareBracket RightSquareBracket { get; }
}
