using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClojureParameterLists;

public interface IClosureParameterClause : IReadOnlyClosureParameterClause, IList<IClosureParameter>
{
    new int Count { get; }

    new IEnumerator<IClosureParameter> GetEnumerator();
    
    new IClosureParameter this[int index] { get; }
}
