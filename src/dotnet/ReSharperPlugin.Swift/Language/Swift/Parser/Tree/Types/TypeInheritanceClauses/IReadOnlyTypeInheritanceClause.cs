using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

public interface IReadOnlyTypeInheritanceClause : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyList<IReadOnlyTypeInheritanceListElement>
{
    Colon Colon { get; }

    IReadOnlyList<IReadOnlyTypeInheritanceListElement> Elements { get; }

    IReadOnlyList<Comma> Commas { get; }

    new IReadOnlyTypeInheritanceListElement this[int index] { get; }
}
