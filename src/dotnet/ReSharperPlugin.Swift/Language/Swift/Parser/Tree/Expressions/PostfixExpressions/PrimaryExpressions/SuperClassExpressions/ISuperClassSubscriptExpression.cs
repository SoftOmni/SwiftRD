using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Arguments;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.SuperClassExpressions;

public interface ISuperClassSubscriptExpression : IReadOnlySuperClassSubscriptExpression, ISuperClassExpression, IList<IFunctionCallArgument>
{
    new IFunctionCallArgumentList ArgumentList { get; }
    
    new IReadOnlyList<IFunctionCallArgument> Arguments { get; }
    
    new int Count { get; }

    new IEnumerator<IFunctionCallArgument> GetEnumerator();
    
    new IFunctionCallArgument this[int index] { get; }
}
