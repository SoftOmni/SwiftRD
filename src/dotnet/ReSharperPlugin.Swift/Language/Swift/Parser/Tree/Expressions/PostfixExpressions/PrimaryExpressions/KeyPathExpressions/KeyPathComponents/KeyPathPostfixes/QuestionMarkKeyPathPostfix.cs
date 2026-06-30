using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.
    KeyPathExpressions.Components.KeyPathPostfixes;

public class QuestionMarkKeyPathPostfix : SwiftCompositeNode, IQuestionMarkKeyPathPostfix
{
    public QuestionMark QuestionMark { get; }

    internal QuestionMarkKeyPathPostfix(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children, QuestionMark questionMark)
        : base(buffer, children)
    {
        QuestionMark = questionMark;
    }
}
