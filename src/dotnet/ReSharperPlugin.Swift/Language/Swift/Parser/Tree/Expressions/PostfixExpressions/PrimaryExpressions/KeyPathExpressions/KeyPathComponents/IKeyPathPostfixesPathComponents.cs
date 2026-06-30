using System.Collections.Generic;
using SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components.KeyPathPostfixes;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components;

public interface IKeyPathPostfixesPathComponents : IReadOnlyKeyPathPostfixesPathComponents,
    IList<IKeyPathPostfix>
{
    new IReadOnlyList<IKeyPathPostfix> KeyPathPostfixes { get; }
    
    new int Count { get; }
    
    new IEnumerator<IKeyPathPostfix> GetEnumerator();
    
    new IKeyPathPostfix this[int index] { get; }
}
