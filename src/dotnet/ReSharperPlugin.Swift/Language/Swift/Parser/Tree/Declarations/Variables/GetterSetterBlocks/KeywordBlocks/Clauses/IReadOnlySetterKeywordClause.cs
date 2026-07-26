using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.KeywordBlocks.Clauses;

public interface IReadOnlySetterKeywordClause : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyAttributeGroup? AttributeGroup { get; }
    
    IReadOnlyMutationModifier? MutationModifier { get; }
    
    Set Set { get; }
}
