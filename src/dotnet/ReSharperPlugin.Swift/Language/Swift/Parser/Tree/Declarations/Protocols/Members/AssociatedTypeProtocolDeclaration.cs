using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols.Members;

public class AssociatedTypeProtocolDeclaration : SwiftCompositeNode, IAssociatedTypeProtocolDeclaration
{
    public IAttributeGroup? Attributes { get; }

    public IAccessLevelModifier? AccessLevelModifier { get; }

    public AssociatedType AssociatedTypeKeyword { get; }

    public IIdentifier TypeAliasName { get; }

    public ITypeInheritanceClause? TypeInheritanceClause { get; }

    public Equal? TypeAliasAssignmentAnnouncer { get; }

    public IType? AliasedType { get; }

    public IGenericWhereClause? GenericsConstraintsClause { get; }


    internal AssociatedTypeProtocolDeclaration(IEditableBuffer buffer,
        IEnumerable<ISwiftNode<SwiftCompositeNode>> children, IAttributeGroup? attributes,
        IAccessLevelModifier? accessLevelModifier, AssociatedType associatedTypeKeyword, IIdentifier typeAliasName,
        ITypeInheritanceClause? typeInheritanceClause, Equal? typeAliasAssignmentAnnouncer, IType? aliasedType,
        IGenericWhereClause? genericsConstraintsClause)
        : base(buffer, children)
    {
        Attributes = attributes;
        AccessLevelModifier = accessLevelModifier;
        AssociatedTypeKeyword = associatedTypeKeyword;
        TypeAliasName = typeAliasName;
        TypeInheritanceClause = typeInheritanceClause;
        TypeAliasAssignmentAnnouncer = typeAliasAssignmentAnnouncer;
        AliasedType = aliasedType;
        GenericsConstraintsClause = genericsConstraintsClause;

        Icon = SwiftIcons.ConstantIcon;
    }

    public AnyCompiledIconClass Icon { get; }
    IReadOnlyAttributeGroup? IReadOnlyAssociatedTypeProtocolDeclaration.Attributes => Attributes;

    IReadOnlyAccessLevelModifier? IReadOnlyAssociatedTypeProtocolDeclaration.AccessLevelModifier => AccessLevelModifier;

    IReadOnlyIdentifier IReadOnlyAssociatedTypeProtocolDeclaration.TypeAliasName => TypeAliasName;

    IReadOnlyTypeInheritanceClause? IReadOnlyAssociatedTypeProtocolDeclaration.TypeInheritanceClause =>
        TypeInheritanceClause;

    IReadOnlyType? IReadOnlyAssociatedTypeProtocolDeclaration.AliasedType => AliasedType;

    IReadOnlyGenericWhereClause? IReadOnlyAssociatedTypeProtocolDeclaration.GenericsConstraintsClause =>
        GenericsConstraintsClause;


    public void SetAttributesTo(IAttributeGroup? newAttributes)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAttributes()
    {
        throw new System.NotImplementedException();
    }

    public void SetAccessLevelModifierTo(IAccessLevelModifier? newAccessLevelModifier)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAccessLevelModifier()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeTypeAliasName(IIdentifier newName)
    {
        throw new System.NotImplementedException();
    }

    public void SetTypeInheritanceClauseTo(ITypeInheritanceClause? newTypeInheritanceClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveTypeInheritanceClause()
    {
        throw new System.NotImplementedException();
    }

    public void SetAliasedTypeTo(IType? newAliasedType)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveAliasedType()
    {
        throw new System.NotImplementedException();
    }

    public void SetGenericsConstraintsClauseTo(IGenericWhereClause? newGenericsConstraintsClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveGenericsConstraintsClause()
    {
        throw new System.NotImplementedException();
    }
}
