using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ProtocolCompositionType;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

public class ProtocolCompositionTypeConformanceRequirement :
    SwiftCompositeNode,
    IProtocolCompositionTypeConformanceRequirement
{
    public ITypeIdentifier TargetType { get; }

    public Colon ConformanceTargetIntroducer { get; }

    public IProtocolCompositionType ProtocolCompositionType { get; }

    internal ProtocolCompositionTypeConformanceRequirement(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, ITypeIdentifier targetType,
        Colon conformanceTargetIntroducer, IProtocolCompositionType protocolCompositionType)
        : base(buffer, children)
    {
        TargetType = targetType;
        ConformanceTargetIntroducer = conformanceTargetIntroducer;
        ProtocolCompositionType = protocolCompositionType;
    }

    IReadOnlyTypeIdentifier IReadOnlyConformanceRequirement.TargetType => TargetType;

    IReadOnlyProtocolCompositionType IReadOnlyProtocolCompositionTypeConformanceRequirement.ProtocolCompositionType =>
        ProtocolCompositionType;

    public void ChangeTargetType(ITypeIdentifier newTargetType)
    {
        throw new System.NotImplementedException();
    }

    public void ChangeProtocolCompositionType(IProtocolCompositionType newProtocolCompositionType)
    {
        throw new System.NotImplementedException();
    }
}
