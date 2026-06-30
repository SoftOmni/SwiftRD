using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components.KeyPathPostfixes;

public interface IReadOnlyArgumentListKeyPathPostfix : IReadOnlyKeyPathPostfix, IReadOnlyList<IReadOnlyFunctionCallArgument>
{
    LeftSquareBracket Start { get; }
    
    IReadOnlyList<IReadOnlyFunctionCallArgument> Arguments { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    RightSquareBracket End { get; }
    
    new IReadOnlyFunctionCallArgument this[int index] { get; }
}
