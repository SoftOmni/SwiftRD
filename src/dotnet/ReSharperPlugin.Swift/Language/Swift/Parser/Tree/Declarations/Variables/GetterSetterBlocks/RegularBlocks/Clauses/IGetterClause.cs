using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks.Clauses;

public interface IGetterClause : IReadOnlyGetterClause
{
    new IAttributeGroup? AttributeGroup { get; }
    
    new IMutationModifier? MutationModifier { get; }
    
    new ICodeBlock CodeBlock { get; }

    void SetAttributeGroupTo(IAttributeGroup? attributeGroup);

    void RemoveAttributeGroup();

    void SetMutationModifierTo(IMutationModifier? mutationModifier);

    void RemoveMutationModifier();

    void ChangeCodeBlock(ICodeBlock newCodeBlock);
}
