using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

public class TypeIdentifierConformanceRequirement :
    SwiftCompositeNode,
    ITypeIdentifierConformanceRequirement
{
    public ITypeIdentifier TargetType { get; }

    public Colon ConformanceTargetIntroducer { get; }

    public ITypeIdentifier TargetConformanceType { get; }

    internal TypeIdentifierConformanceRequirement(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, ITypeIdentifier targetType,
        Colon conformanceTargetIntroducer, ITypeIdentifier targetConformanceType)
        : base(buffer, children)
    {
        TargetType = targetType;
        ConformanceTargetIntroducer = conformanceTargetIntroducer;
        TargetConformanceType = targetConformanceType;
    }

    IReadOnlyTypeIdentifier IReadOnlyConformanceRequirement.TargetType => TargetType;

    IReadOnlyTypeIdentifier IReadOnlyTypeIdentifierConformanceRequirement.TargetConformanceType =>
        TargetConformanceType;

    public void ChangeTargetType(ITypeIdentifier newTargetType)
    {
        throw new NotImplementedException();
    }

    public void ChangeTargetConformanceType(ITypeIdentifier newTargetConformanceType)
    {
        throw new NotImplementedException();
    }
}
