using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.KeyPathExpressions.Components.KeyPathPostfixes;

public class ExclamationMarkKeyPathPostfix : SwiftCompositeNode, IExclamationMarkKeyPathPostfix
{
    public ExclamationMark ExclamationMark { get; }

    internal ExclamationMarkKeyPathPostfix(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, ExclamationMark exclamationMark)
        : base(buffer, children)
    {
        ExclamationMark = exclamationMark;
    }
}
