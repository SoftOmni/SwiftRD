using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks.Clauses;

public interface IReadOnlyGetterClause : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyAttributeGroup? AttributeGroup { get; }
    
    IReadOnlyMutationModifier? MutationModifier { get; }
    
    Get Get { get; }
    
    IReadOnlyCodeBlock CodeBlock { get; }
}
