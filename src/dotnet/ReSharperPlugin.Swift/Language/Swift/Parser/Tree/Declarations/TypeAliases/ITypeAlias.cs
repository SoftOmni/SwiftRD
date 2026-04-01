using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TypeAliases;

public interface ITypeAlias : ISwiftNode<SwiftCompositeNode>, IDeclaration<IType>, INamedDeclaration<ITypeAlias, IType>
{
    public AttributeGroup? Attributes { get; }

    public IAccessLevelModifier? AccessLevelModifier { get; }

    public TypeAliasKeyword? Keyword { get; }
    
    public GenericParameterClause? GenericParameterClause { get; }

    public Equal? Equal { get; }

    public IType? Type { get; }

    public bool HasAttributes { get; }

    public bool IsAttributeless { get; }

    public bool AccessLevelModifierSpecified { get; }

    public bool IsDefaultAccessLevelModifier { get; }

    public IAccessLevelModifier ActiveAccessLevelModifier { get; }
}