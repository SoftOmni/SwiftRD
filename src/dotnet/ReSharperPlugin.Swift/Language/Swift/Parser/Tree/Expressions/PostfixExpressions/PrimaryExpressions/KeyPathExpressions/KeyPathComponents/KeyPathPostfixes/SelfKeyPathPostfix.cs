using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ISelfExpressions;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components.KeyPathPostfixes;

public class SelfKeyPathPostfix : SwiftCompositeNode, ISelfKeyPathPostfix
{
    public SelfLowercase Self { get; }

    internal SelfKeyPathPostfix(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, SelfLowercase self)
        : base(buffer, children)
    {
        Self = self;
    }
}
