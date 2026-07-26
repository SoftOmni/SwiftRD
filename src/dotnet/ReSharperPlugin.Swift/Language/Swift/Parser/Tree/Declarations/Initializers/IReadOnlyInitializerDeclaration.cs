using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers.Inits;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;

public interface IReadOnlyInitializerDeclaration : ISwiftNode<SwiftCompositeNode>
{
    IReadOnlyAttributeGroup? Attributes { get; }
    
    IReadOnlyDeclarationModifierGroup? DeclarationModifiers { get; }
    
    IReadOnlyInit InitKeyword { get; }
    
    IReadOnlyParameterClause Parameters { get; }
    
    Async? AsyncKeyword { get; }
    
    IReadOnlyGenericWhereClause? GenericsConstraintClause { get; }
    
    IReadOnlyCodeBlock CodeBlock { get; }
}
