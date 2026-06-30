using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions;

public interface IKeyPathExpression : IReadOnlyKeyPathExpression, IPrimaryExpression, IList<IKeyPathComponent>
{
    new IType? Type { get; }
    
    new IReadOnlyList<IKeyPathComponent> KeyPathComponents { get; }
    
    new int Count { get; }

    new IEnumerator<IKeyPathComponent> GetEnumerator();
    
    new IKeyPathComponent this[int index] { get; }
}
