using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

public interface IReadOnlyConformanceRequirement : IReadOnlyRequirement
{
    IReadOnlyTypeIdentifier TargetType { get; }
    
    Colon ConformanceTargetIntroducer { get; }
}
