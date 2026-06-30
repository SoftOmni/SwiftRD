using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components.KeyPathPostfixes;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components;

public interface IReadOnlyIdentifierKeyPathComponent : IReadOnlyKeyPathComponent, 
    IReadOnlyList<IReadOnlyKeyPathPostfix>
{
    IReadOnlyIdentifier Identifier { get; }
    
    IReadOnlyList<IReadOnlyKeyPathPostfix>? KeyPathPostfixes { get; }
    
    new IReadOnlyKeyPathPostfix this[int index] { get; }
}
