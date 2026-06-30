using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components.KeyPathPostfixes;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components;

public interface IIdentifierKeyPathComponent : IReadOnlyIdentifierKeyPathComponent,
    IKeyPathComponent, IList<IKeyPathPostfix>
{
    new IIdentifier Identifier { get; }
    
    new IReadOnlyList<IKeyPathPostfix>? KeyPathPostfixes { get; }
    
    new IKeyPathPostfix this[int index] { get; set; }
    
    new int Count { get; }

    new IEnumerator<IKeyPathPostfix> GetEnumerator();

    void ChangeIdentifier(IIdentifier newIdentifier);
}
