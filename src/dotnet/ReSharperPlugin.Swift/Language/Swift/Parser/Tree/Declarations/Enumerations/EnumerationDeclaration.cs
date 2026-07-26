using System.Collections;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Members;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Indirecterations;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations;

public class EnumerationDeclaration : SwiftCompositeNode, IEnumerationDeclaration
{
    public IAttributeGroup? Attributes { get; }

    public IAccessLevelModifier? AccessLevelModifier { get; }

    public Indirect? IndirectKeyword { get; }

    public Enum EnumKeyword { get; }

    public IIdentifier Name { get; }

    public IGenericParameterClause? GenericParameterClause { get; }

    public ITypeInheritanceClause? TypeInheritanceClause { get; }

    public IGenericWhereClause? GenericWhereClause { get; }

    public LeftCurlyBrace MembersStartBrace { get; }

    public ISwitchCaseMembers Members { get; }

    public RightCurlyBrace MembersEndBrace { get; }

    internal EnumerationDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IAccessLevelModifier? accessLevelModifier, Indirect? indirectKeyword,
        Enum enumKeyword, IIdentifier name, IGenericParameterClause? genericParameterClause,
        ITypeInheritanceClause? typeInheritanceClause, IGenericWhereClause? genericWhereClause,
        LeftCurlyBrace membersStartBrace, ISwitchCaseMembers members, RightCurlyBrace membersEndBrace)
        : base(buffer, children)
    {
        Attributes = attributes;
        AccessLevelModifier = accessLevelModifier;
        IndirectKeyword = indirectKeyword;
        EnumKeyword = enumKeyword;
        Name = name;
        GenericParameterClause = genericParameterClause;
        TypeInheritanceClause = typeInheritanceClause;
        GenericWhereClause = genericWhereClause;
        MembersStartBrace = membersStartBrace;
        Members = members;
        MembersEndBrace = membersEndBrace;
    }

    IReadOnlyAttributeGroup? IReadOnlyEnumerationDeclaration.Attributes => Attributes;

    IReadOnlyAccessLevelModifier? IReadOnlyEnumerationDeclaration.AccessLevelModifier => AccessLevelModifier;

    IReadOnlyIdentifier IReadOnlyEnumerationDeclaration.Name => Name;

    IReadOnlyGenericParameterClause? IReadOnlyEnumerationDeclaration.GenericParameterClause => GenericParameterClause;

    IReadOnlyTypeInheritanceClause? IReadOnlyEnumerationDeclaration.TypeInheritanceClause => TypeInheritanceClause;

    IReadOnlyGenericWhereClause? IReadOnlyEnumerationDeclaration.GenericWhereClause => GenericWhereClause;

    IReadOnlySwitchCaseMembers IReadOnlyEnumerationDeclaration.Members => Members;

    IReadOnlyList<IReadOnlySwitchCaseMember> IReadOnlyEnumerationDeclaration.MembersAsList => MembersAsList;

    public IReadOnlyList<ISwitchCaseMember> MembersAsList => Members.Members;

    public int Count => Members.Count;

    public bool IsReadOnly => Members.IsReadOnly;

    public new ISwitchCaseMember this[int index]
    {
        get => Members[index];
        set => Members[index] = value;
    }

    IReadOnlySwitchCaseMember IReadOnlyList<IReadOnlySwitchCaseMember>.this[int index]
        => Members[index];

    IReadOnlySwitchCaseMember IReadOnlyEnumerationDeclaration.this[int index]
        => Members[index];

    public IEnumerator<ISwitchCaseMember> GetEnumerator()
    {
        return Members.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlySwitchCaseMember> IEnumerable<IReadOnlySwitchCaseMember>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public void Add(ISwitchCaseMember item)
    {
        Members.Add(item);
    }

    public void Clear()
    {
        Members.Clear();
    }

    public bool Contains(ISwitchCaseMember item)
    {
        return Members.Contains(item);
    }

    public void CopyTo(ISwitchCaseMember[] array, int arrayIndex)
    {
        Members.CopyTo(array, arrayIndex);
    }

    public int IndexOf(ISwitchCaseMember item)
    {
        return Members.IndexOf(item);
    }

    public bool Remove(ISwitchCaseMember item)
    {
        return Members.Remove(item);
    }

    public void Insert(int index, ISwitchCaseMember item)
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

    public void SetGenericParameterClauseTo(IGenericParameterClause newGenericParameterClause)
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

    public void SetGenericWhereClauseTo(IGenericWhereClause? newGenericWhereClause)
    {
        throw new System.NotImplementedException();
    }

    public void RemoveGenericWhereClause()
    {
        throw new System.NotImplementedException();
    }

    public void ChangeMembers(ISwitchCaseMembers newMembers)
    {
        throw new System.NotImplementedException();
    }
}
