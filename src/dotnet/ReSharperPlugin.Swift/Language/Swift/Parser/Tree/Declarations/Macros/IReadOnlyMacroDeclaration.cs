using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Macros;

public interface IReadOnlyMacroDeclaration
    : IReadOnlyDeclaration
{
    IReadOnlyAttributeGroup? Attributes { get; }
    
    IReadOnlyDeclarationModifierGroup? DeclarationModifiers { get; }
    
    Macro MacroKeyword { get; }
    
    IReadOnlyIdentifier Name { get; }
    
    IReadOnlyGenericParameterClause? GenericParameterClause { get; }
    
    IReadOnlyParameterClause Parameters { get; }
    
    Arrow ReturnTypeAnnouncer { get; }
    
    IReadOnlyType ReturnType { get; }
    
    IReadOnlyMacroDefinition? MacroDefinition { get; }
    
    IReadOnlyGenericWhereClause? GenericsConstraintsClause { get; }
}
