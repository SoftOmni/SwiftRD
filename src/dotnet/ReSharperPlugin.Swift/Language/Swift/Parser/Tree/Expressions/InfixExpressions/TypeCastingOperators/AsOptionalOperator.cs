using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

public class AsOptionalOperator : SwiftCompositeNode, IAsOptionalOperator
{
    public As As { get; }

    public QuestionMark QuestionMark { get; }

    public AsOptionalOperator(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        As @as, QuestionMark questionMark)
        : base(buffer, children)
    {
        As = @as;
        QuestionMark = questionMark;
    }

    public IReadOnlyTypeCastingOperator.Kind CurrentKind => IReadOnlyTypeCastingOperator.Kind.AsOptional;
}
