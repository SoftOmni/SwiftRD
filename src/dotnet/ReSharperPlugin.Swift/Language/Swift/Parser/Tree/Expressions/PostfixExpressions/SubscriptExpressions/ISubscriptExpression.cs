using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.SubscriptExpressions;

public interface ISubscriptExpression : IReadOnlySubscriptExpression, IPostfixExpression, IList<IFunctionCallArgument>
{
    new IPostfixExpression PostfixExpression { get; }

    void ChangePostfixExpression();
    
    new IReadOnlyList<IFunctionCallArgument> FunctionCallArguments { get; }
    
    new int Count { get; }

    new IEnumerator<IFunctionCallArgument> GetEnumerator();
    
    new IFunctionCallArgument this[int index] { get; }
}
