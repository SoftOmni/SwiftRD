using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks.Clauses;

public interface IReadOnlySetterClause : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyAttributeGroup? AttributeGroup { get; }
    
    IReadOnlyMutationModifier? MutationModifier { get; }
    
    Set Set { get; }
    
    LeftParenthesis? SetterNameStart { get; }
    
    IReadOnlyIdentifier? SetterName { get; }
    
    RightParenthesis? SetterNameEnd { get; }
    
    IReadOnlyCodeBlock CodeBlock { get; }
}
