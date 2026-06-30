using System.Collections.Generic;
using SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components.KeyPathPostfixes;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components;

public interface IReadOnlyKeyPathPostfixesPathComponents : IReadOnlyKeyPathComponent, IReadOnlyList<IReadOnlyKeyPathPostfix>
{
    IReadOnlyList<IReadOnlyKeyPathPostfix> KeyPathPostfixes { get; }
    
    new IReadOnlyKeyPathPostfix this[int index] { get; }
}
