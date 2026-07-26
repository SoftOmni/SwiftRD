using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

public class LiteralSameTypeRequirement : SwiftCompositeNode, ILiteralSameTypeRequirement
{
    public ITypeIdentifier TargetType { get; }

    public IReadOnlyOperator SameTypeTargetIntroducer { get; }

    public ILiteral Literal { get; }

    internal LiteralSameTypeRequirement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ITypeIdentifier targetType, IReadOnlyOperator sameTypeTargetIntroducer, ILiteral literal)
        : base(buffer, children)
    {
        TargetType = targetType;
        SameTypeTargetIntroducer = sameTypeTargetIntroducer;
        Literal = literal;
    }

    IReadOnlyTypeIdentifier IReadOnlySameTypeRequirement.TargetType => TargetType;

    IReadOnlyLiteral IReadOnlyLiteralSameTypeRequirement.Literal => Literal;

    public void ChangeTargetType(ITypeIdentifier newTargetType)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeLiteral(ILiteral newLiteral)
    {
        throw new System.NotImplementedException();
    }
}
