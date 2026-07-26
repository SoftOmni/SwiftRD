using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;

public interface IReadOnlyVariable : IReadOnlyDeclaration
{
    IReadOnlyAttributeGroup? Attributes { get; }
    
    IReadOnlyDeclarationModifierGroup? DeclarationModifiers { get; }
    
    Var Keyword { get; }
}
