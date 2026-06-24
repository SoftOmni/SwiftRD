using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

public interface IReadOnlyTypeInheritanceListElement
{
    IReadOnlyAttributeGroup? AttributeGroup { get; }
    
    IReadOnlyOperator? Tilde { get; }
    
    IReadOnlyTypeIdentifier TypeIdentifier { get; }
}
