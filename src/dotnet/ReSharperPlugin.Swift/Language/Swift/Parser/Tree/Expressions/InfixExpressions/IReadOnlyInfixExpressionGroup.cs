using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions;

public interface IReadOnlyInfixExpressionGroup : ISwiftInternalNode<SwiftCompositeNode>, IReadOnlyList<IReadOnlyInfixExpression>
{
    new int Count { get; }

    new IEnumerator<IReadOnlyInfixExpression> GetEnumerator();

    new IReadOnlyInfixExpression this[int index] { get; }
    
    IReadOnlyList<IReadOnlyInfixExpression> InfixExpressions { get; }
}

