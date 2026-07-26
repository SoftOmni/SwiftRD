using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public class ConsumingParameterModifier : SwiftCompositeNode, IConsumingParameterModifier
{
    public Consuming Keyword { get; }

    internal ConsumingParameterModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Consuming keyword)
        : base(buffer, children)
    {
        Keyword = keyword;
    }
}