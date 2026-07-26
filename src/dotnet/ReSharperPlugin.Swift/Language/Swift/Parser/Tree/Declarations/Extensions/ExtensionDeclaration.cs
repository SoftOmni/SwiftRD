using System.Collections;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Extensions;

public class ExtensionDeclaration : SwiftCompositeNode, IExtensionDeclaration
{
    public IAttributeGroup? Attributes { get; }

    public IAccessLevelModifier? AccessLevelModifier { get; }

    public Extension ExtensionKeyword { get; }

    public IIdentifier Name { get; }

    public IGenericParameterClause? GenericParameterClause { get; }

    public ITypeInheritanceClause? TypeInheritanceClause { get; }

    public IGenericWhereClause? GenericConstraintsClause { get; }

    public LeftCurlyBrace MembersStart { get; }

    public IExtensionMembers Members { get; }

    public RightCurlyBrace MembersEnd { get; }

    internal ExtensionDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IAccessLevelModifier? accessLevelModifier, Extension extensionKeyword, IIdentifier name,
        IGenericParameterClause? genericParameterClause, ITypeInheritanceClause? typeInheritanceClause,
        IGenericWhereClause? genericConstraintsClause, LeftCurlyBrace membersStart, IExtensionMembers members,
        RightCurlyBrace membersEnd)
        : base(buffer, children)
    {
        Attributes = attributes;
        AccessLevelModifier = accessLevelModifier;
        ExtensionKeyword = extensionKeyword;
        Name = name;
        GenericParameterClause = genericParameterClause;
        TypeInheritanceClause = typeInheritanceClause;
        GenericConstraintsClause = genericConstraintsClause;
        MembersStart = membersStart;
        Members = members;
        MembersEnd = membersEnd;

        Icon = SwiftIcons.ConstantIcon;
    }

    public AnyCompiledIconClass Icon { get; }

    public IReadOnlyList<IExtensionMember> MembersAsList => Members.Members;

    IReadOnlyAttributeGroup? IReadOnlyExtensionDeclaration.Attributes => Attributes;

    IReadOnlyAccessLevelModifier? IReadOnlyExtensionDeclaration.AccessLevelModifier => AccessLevelModifier;

    IReadOnlyIdentifier IReadOnlyExtensionDeclaration.Name => Name;

    IReadOnlyGenericParameterClause? IReadOnlyExtensionDeclaration.GenericParameterClause => GenericParameterClause;

    IReadOnlyTypeInheritanceClause? IReadOnlyExtensionDeclaration.TypeInheritanceClause => TypeInheritanceClause;

    IReadOnlyGenericWhereClause? IReadOnlyExtensionDeclaration.GenericConstraintsClause => GenericConstraintsClause;

    IReadOnlyExtensionMembers IReadOnlyExtensionDeclaration.Members => Members;

    IReadOnlyList<IReadOnlyExtensionMember> IReadOnlyExtensionDeclaration.MembersAsList => MembersAsList;

    public int Count => Members.Count;

    public bool IsReadOnly => false;

    public new IExtensionMember this[int index]
    {
        get => Members[index];
        set => Members[index] = value;
    }

    IReadOnlyExtensionMember IReadOnlyList<IReadOnlyExtensionMember>.this[int index]
        => Members[index];

    IReadOnlyExtensionMember IReadOnlyExtensionDeclaration.this[int index]
        => Members[index];

    public IEnumerator<IExtensionMember> GetEnumerator()
    {
        return Members.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyExtensionMember> IEnumerable<IReadOnlyExtensionMember>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IExtensionMember item)
    {
        return Members.Contains(item);
    }

    public int IndexOf(IExtensionMember item)
    {
        return Members.IndexOf(item);
    }

    public void CopyTo(IExtensionMember[] array, int arrayIndex)
    {
        Members.CopyTo(array, arrayIndex);
    }

    public void Add(IExtensionMember item)
    {
        Members.Add(item);
    }

    public void Clear()
    {
        Members.Clear();
    }

    public bool Remove(IExtensionMember item)
    {
        return Members.Remove(item);
    }

    public void Insert(int index, IExtensionMember item)
    {
        Members.Insert(index, item);
    }

    public void RemoveAt(int index)
    {
        Members.RemoveAt(index);
    }

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

    public void ChangeName(IIdentifier newName)
    {
        throw new System.NotImplementedException();
    }

    public void SetGenericParameterClauseTo(IGenericParameterClause? newGenericParameterClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveGenericParameterClause()
    {
        throw new System.NotImplementedException();
    }

    public void SetTypeInheritanceClauseTo(ITypeInheritanceClause newTypeInheritanceClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveTypeInheritanceClause()
    {
        throw new System.NotImplementedException();
    }

    public void SetGenericConstraintsClauseTo(IGenericWhereClause? newGenericConstraintsClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveGenericConstraintsClause()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeMembers(IExtensionMembers newExtensionMembers)
    {
        throw new System.NotImplementedException();
    }
}