using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;

namespace ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Declarations.Enumerations;

public interface IReadOnlyEnumeration : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyAttributeGroup? Attributes { get; }
    
    IReadOnlyAccessLevelModifier? AccessLevelModifier { get; }
}
