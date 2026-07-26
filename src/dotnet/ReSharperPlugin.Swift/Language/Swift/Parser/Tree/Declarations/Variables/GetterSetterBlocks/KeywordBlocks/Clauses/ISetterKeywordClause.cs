using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.KeywordBlocks.Clauses;

public interface ISetterKeywordClause : IReadOnlySetterKeywordClause
{
    new IAttributeGroup? AttributeGroup { get; }
    
    new IMutationModifier? MutationModifier { get; }

    void SetAttributeGroupTo(IAttributeGroup? attributeGroup);

    void RemoveAttributeGroup();

    void SetMutationModifierTo(IMutationModifier? mutationModifier);

    void RemoveMutationModifier();
}
