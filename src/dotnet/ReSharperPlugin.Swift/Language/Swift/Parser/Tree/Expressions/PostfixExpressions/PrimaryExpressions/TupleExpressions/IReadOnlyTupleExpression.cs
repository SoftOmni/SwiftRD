using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.TupleExpressions;

public interface IReadOnlyTupleExpression : IReadOnlyPrimaryExpression, IReadOnlyList<IReadOnlyTupleExpressionElement>
{
    LeftParenthesis LeftParenthesis { get; }
    
    IReadOnlyList<IReadOnlyTupleExpressionElement> Elements { get; }
    
    IReadOnlyList<Comma> Commas { get; }
    
    RightParenthesis RightParenthesis { get; }
    
    int NumberOfElements { get; }
    
    int NumberOfCommas { get; }
    
    bool IsVoid { get; }
}
