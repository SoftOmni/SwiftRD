using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks.Clauses;

public interface IDidSetClause : IReadOnlyDidSetClause
{
    new IAttributeGroup? Attributes { get; }
    
    new IIdentifier? SetterName { get; }
    
    new ICodeBlock CodeBlock { get; }

    void SetAttributeGroupTo(IAttributeGroup? attributeGroup);

    void RemoveAttributeGroup();

    void SetSetterNameTo(IIdentifier? setterName);

    void RemoveSetterName();

    void ChangeCodeBlock(ICodeBlock newCodeBlock);
}
