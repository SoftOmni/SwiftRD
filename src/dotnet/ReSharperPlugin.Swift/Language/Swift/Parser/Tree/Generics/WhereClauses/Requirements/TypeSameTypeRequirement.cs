using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

public class TypeSameTypeRequirement : SwiftCompositeNode, ITypeSameTypeRequirement
{
    public ITypeIdentifier TargetType { get; }

    public IReadOnlyOperator SameTypeTargetIntroducer { get; }

    public IType SameTypeTargetType { get; }

    internal TypeSameTypeRequirement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ITypeIdentifier targetType, IReadOnlyOperator sameTypeTargetIntroducer, IType sameTypeTargetType)
        : base(buffer, children)
    {
        TargetType = targetType;
        SameTypeTargetIntroducer = sameTypeTargetIntroducer;
        SameTypeTargetType = sameTypeTargetType;
    }

    IReadOnlyTypeIdentifier IReadOnlySameTypeRequirement.TargetType => TargetType;

    IReadOnlyType IReadOnlyTypeSameTypeRequirement.SameTypeTargetType => SameTypeTargetType;

    public void ChangeTargetType(ITypeIdentifier newTargetType)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeSameTypeTargetType(IType newSameTypeTargetType)
    {
        throw new System.NotImplementedException();
    }
}
