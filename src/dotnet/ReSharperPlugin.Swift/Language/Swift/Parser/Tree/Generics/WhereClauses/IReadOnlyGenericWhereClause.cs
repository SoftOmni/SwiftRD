using System.Collections.Generic;
using SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.GenericWhereClauseClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;

public interface IReadOnlyGenericWhereClause : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyRequirement>
{
    Where WhereKeyword { get; }
    
    IReadOnlyList<IReadOnlyRequirement> Requirements { get; }
    
    IReadOnlyList<Comma> RequirementSeparators { get; }
    
    new IReadOnlyRequirement this[int index] { get; }
}
