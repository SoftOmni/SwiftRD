using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;

public interface IReadOnlyConstantDeclaration : IReadOnlyDeclaration
{
    IReadOnlyAttributeGroup? AttributeGroup { get; }
    
    IReadOnlyDeclarationModifierGroup? DeclarationModifierGroup { get; }
    
    Let Keyword { get; }
    
    IReadOnlyPatternInitializerList PatternInitializerList { get; }
}
