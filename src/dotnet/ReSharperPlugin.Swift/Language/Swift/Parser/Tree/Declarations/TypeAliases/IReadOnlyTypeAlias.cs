using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TypeAliases;

public interface IReadOnlyTypeAlias : ISwiftNode<SwiftCompositeNode>,
    IReadOnlyDeclaration
{
    IReadOnlyAttributeGroup? AttributeGroup { get; }
    
    IReadOnlyAccessLevelModifier? AccessLevelModifier { get; }
    
    TypeAlias? TypeAlias { get; }
    
    IReadOnlyIdentifier? Name { get; }
    
    IReadOnlyGenericArgumentClause? GenericArgumentClause { get; }
    
    Equal? AssignmentOperator { get; }
    
    IReadOnlyType? Type { get; }
}
