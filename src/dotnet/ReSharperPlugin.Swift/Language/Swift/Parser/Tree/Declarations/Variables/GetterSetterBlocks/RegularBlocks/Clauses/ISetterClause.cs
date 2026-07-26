using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks.Clauses;

public interface ISetterClause : IReadOnlySetterClause
{
    new IAttributeGroup? AttributeGroup { get; }
    
    new IMutationModifier? MutationModifier { get; }
    
    new IIdentifier? SetterName { get; }
    
    new ICodeBlock CodeBlock { get; }

    void SetAttributeGroupTo(IAttributeGroup? attributeGroup);

    void RemoveAttributeGroup();

    void SetMutationModifierTo(IMutationModifier? mutationModifier);

    void RemoveMutationModifier();

    void SetSetterNameTo(IIdentifier? setterName);

    void RemoveSetterName();

    void ChangeCodeBlock(ICodeBlock newCodeBlock);
}
