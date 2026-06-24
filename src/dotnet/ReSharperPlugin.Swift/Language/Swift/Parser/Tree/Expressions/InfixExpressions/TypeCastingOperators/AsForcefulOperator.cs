using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.InfixExpressions.TypeCastingOperators;

public class AsForcefulOperator : SwiftCompositeNode, IAsForcefulOperator
{
    public As As { get; }

    public ExclamationMark ExclamationMark { get; }

    public AsForcefulOperator(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        As @as, ExclamationMark exclamationMark)
        : base(buffer, children)
    {
        As = @as;
        ExclamationMark = exclamationMark;
    }

    public IReadOnlyTypeCastingOperator.Kind CurrentKind => IReadOnlyTypeCastingOperator.Kind.AsForceful;
}
