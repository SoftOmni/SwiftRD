using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Relations;

public interface IReadOnlyPrecedenceGroupRelation : IReadOnlyPrecedenceGroupAttribute,
    ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyIdentifier>
{
    Colon PrecedenceGroupNamesIntroducer { get; }

    IReadOnlyList<IReadOnlyIdentifier> PrecedenceGroupNames { get; }

    IReadOnlyList<Comma> PrecedenceGroupNameSeparators { get; }
    
    new IReadOnlyIdentifier this[int index] { get; }
}
