using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Indirecterations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.UnionValues;

public interface IReadOnlyUnionStyleEnumCaseClause :
    ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyUnionStyleMember,
    IReadOnlyList<IReadOnlyUnionStyleEnumCase>
{
    IReadOnlyAttributeGroup? Attributes { get; }

    Indirect? IndirectKeyword { get; }

    Case CaseKeyword { get; }

    IReadOnlyList<IReadOnlyUnionStyleEnumCase> Cases { get; }

    IReadOnlyList<Comma> CaseSeparators { get; }
    
    new IReadOnlyUnionStyleEnumCase this[int index] { get; }
}
