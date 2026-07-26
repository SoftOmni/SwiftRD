using System;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.TypeAliases;

public class TypeAlias : SwiftCompositeNode, ITypeAlias
{
    public IAttributeGroup? Attributes { get; }

    public IAccessLevelModifier? AccessLevelModifier { get; }

    public TypeAliasKeyword Keyword { get; }

    public IIdentifier Name { get; }

    public IGenericArgumentClause? GenericArgumentClause { get; }

    public Equal AssignmentOperator { get; }

    public IType Type { get; }

    internal TypeAlias(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IAccessLevelModifier? accessLevelModifier, TypeAliasKeyword typeAliasKeyword,
        IIdentifier name, IGenericArgumentClause? genericArgumentClause, Equal assignmentOperator, IType type)
        : base(buffer, children)
    {
        Attributes = attributes;
        AccessLevelModifier = accessLevelModifier;
        Keyword = typeAliasKeyword;
        Name = name;
        GenericArgumentClause = genericArgumentClause;
        AssignmentOperator = assignmentOperator;
        Type = type;

        Icon = SwiftIcons.ConstantIcon; // TODO: change
    }

    public AnyCompiledIconClass Icon { get; }

    IReadOnlyAttributeGroup? IReadOnlyTypeAlias.Attributes => Attributes;

    IReadOnlyAccessLevelModifier? IReadOnlyTypeAlias.AccessLevelModifier => AccessLevelModifier;

    IReadOnlyIdentifier IReadOnlyTypeAlias.Name => Name;

    IReadOnlyGenericArgumentClause? IReadOnlyTypeAlias.GenericArgumentClause => GenericArgumentClause;

    IReadOnlyType IReadOnlyTypeAlias.Type => Type;

    public void SetAttributesTo(IAttributeGroup? newAttributes)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributes()
    {
        throw new NotImplementedException();
    }

    public void SetAccessLevelModifierTo(IAccessLevelModifier? newAccessLevelModifier)
    {
        throw new NotImplementedException();
    }

    public void RemoveAccessLevelModifier()
    {
        throw new NotImplementedException();
    }

    public void ChangeName(IIdentifier newName)
    {
        throw new NotImplementedException();
    }

    public void SetGenericArgumentClauseTo(IGenericArgumentClause? newGenericArgumentClause)
    {
        throw new NotImplementedException();
    }

    public void RemoveGenericArgumentClause()
    {
        throw new NotImplementedException();
    }

    public void ChangeType(IType newType)
    {
        throw new NotImplementedException();
    }
}
