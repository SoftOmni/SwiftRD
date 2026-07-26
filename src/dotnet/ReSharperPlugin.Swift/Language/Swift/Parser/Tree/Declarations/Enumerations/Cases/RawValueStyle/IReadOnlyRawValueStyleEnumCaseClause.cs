using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Members.RawValueStyle;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.RawValue;

public interface IReadOnlyRawValueStyleEnumCaseClause : ISwiftInternalNode<SwiftCompositeNode>,
    IRawValueStyleMember,
    IReadOnlyList<IReadOnlyRawValueStyleEnumCase>
{
    IReadOnlyAttributeGroup? Attributes { get; }
    
    Case Case { get; }
    
    IReadOnlyList<IReadOnlyRawValueStyleEnumCase> Cases { get; }
    
    IReadOnlyList<Comma> CaseSeparators { get; }
    
    new IReadOnlyRawValueStyleEnumCase this[int index] { get; }
}
