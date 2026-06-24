using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.ThrowClauses;

public class NonSpecificThrowsClause : SwiftCompositeNode, IThrowsClause
{
    public Throws Throws { get; }

    internal NonSpecificThrowsClause(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Throws throws)
        : base(buffer, children)
    {
        Throws = throws;
    }
}

