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

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Structs;

public class StructureDeclaration : SwiftCompositeNode, IStructureDeclaration
{
    public IAttributeGroup? Attributes { get; }

    public IAccessLevelModifier? AccessLevelModifier { get; }

    public Struct StructKeyword { get; }

    public IIdentifier Name { get; }

    public IGenericParameterClause? GenericParameterClause { get; }

    public ITypeInheritanceClause? TypeInheritanceClause { get; }

    public IGenericWhereClause? GenericConstraintsClause { get; }

    public LeftCurlyBrace MembersStart { get; }

    public IStructMembers Members { get; }

    public RightCurlyBrace MembersEnd { get; }

    internal StructureDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IAccessLevelModifier? accessLevelModifier, Struct structKeyword, IIdentifier name,
        IGenericParameterClause? genericParameterClause, ITypeInheritanceClause? typeInheritanceClause,
        IGenericWhereClause? genericConstraintsClause, LeftCurlyBrace membersStart, IStructMembers members,
        RightCurlyBrace membersEnd)
        : base(buffer, children)
    {
        Attributes = attributes;
        AccessLevelModifier = accessLevelModifier;
        StructKeyword = structKeyword;
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

    public IReadOnlyList<IStructMember> MembersAsList => Members.Members;

    IReadOnlyAttributeGroup? IReadOnlyStructureDeclaration.Attributes => Attributes;

    IReadOnlyAccessLevelModifier? IReadOnlyStructureDeclaration.AccessLevelModifier => AccessLevelModifier;

    IReadOnlyIdentifier IReadOnlyStructureDeclaration.Name => Name;

    IReadOnlyGenericParameterClause? IReadOnlyStructureDeclaration.GenericParameterClause => GenericParameterClause;

    IReadOnlyTypeInheritanceClause? IReadOnlyStructureDeclaration.TypeInheritanceClause => TypeInheritanceClause;

    IReadOnlyGenericWhereClause? IReadOnlyStructureDeclaration.GenericConstraintsClause => GenericConstraintsClause;

    IReadOnlyStructMembers IReadOnlyStructureDeclaration.Members => Members;

    IReadOnlyList<IReadOnlyStructMember> IReadOnlyStructureDeclaration.MembersAsList => MembersAsList;

    public int Count => Members.Count;

    public bool IsReadOnly => false;

    public new IStructMember this[int index]
    {
        get => Members[index];
        set => Members[index] = value;
    }

    IReadOnlyStructMember IReadOnlyList<IReadOnlyStructMember>.this[int index]
        => Members[index];

    IReadOnlyStructMember IReadOnlyStructureDeclaration.this[int index]
        => Members[index];

    public IEnumerator<IStructMember> GetEnumerator()
    {
        return Members.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyStructMember> IEnumerable<IReadOnlyStructMember>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IStructMember item)
    {
        return Members.Contains(item);
    }

    public int IndexOf(IStructMember item)
    {
        return Members.IndexOf(item);
    }

    public void CopyTo(IStructMember[] array, int arrayIndex)
    {
        Members.CopyTo(array, arrayIndex);
    }

    public void Add(IStructMember item)
    {
        Members.Add(item);
    }

    public void Clear()
    {
        Members.Clear();
    }

    public bool Remove(IStructMember item)
    {
        return Members.Remove(item);
    }

    public void Insert(int index, IStructMember item)
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

    public void ChangeMembers(IStructMembers newStructMembers)
    {
        throw new System.NotImplementedException();
    }
}