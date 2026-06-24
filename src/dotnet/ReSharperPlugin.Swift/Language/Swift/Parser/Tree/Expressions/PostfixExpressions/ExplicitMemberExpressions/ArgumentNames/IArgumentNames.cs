using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.ExplicitMemberExpressions.ArgumentNames;

public interface IArgumentNames : IReadOnlyArgumentNames, IList<IIdentifier>
{
    new int Count { get; }

    new IEnumerator<IIdentifier> GetEnumerator();
    
    new IIdentifier this[int index] { get; }
}
