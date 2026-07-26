using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;

public interface IVariable : IReadOnlyVariable, IDeclaration
{
    new IAttributeGroup? Attributes { get; }
    
    new IDeclarationModifierGroup? DeclarationModifiers { get; }

    void SetAttributesTo(IAttributeGroup? attributes);

    void RemoveAttributes();

    void SetDeclarationModifiers();

    void RemoveDeclarationModifiers();
}
