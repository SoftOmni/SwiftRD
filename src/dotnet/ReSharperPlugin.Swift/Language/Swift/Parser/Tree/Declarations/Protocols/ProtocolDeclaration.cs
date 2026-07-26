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

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;

public class ProtocolDeclaration : SwiftCompositeNode, IProtocolDeclaration
{
    public IAttributeGroup? Attributes { get; }

    public IAccessLevelModifier? AccessLevelModifier { get; }

    public Protocol ProtocolKeyword { get; }

    public IIdentifier Name { get; }

    public IGenericParameterClause? GenericParameterClause { get; }

    public ITypeInheritanceClause? TypeInheritanceClause { get; }

    public IGenericWhereClause? GenericConstraintsClause { get; }

    public LeftCurlyBrace MembersStart { get; }

    public IProtocolMembers Members { get; }

    public RightCurlyBrace MembersEnd { get; }

    internal ProtocolDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IAccessLevelModifier? accessLevelModifier, Protocol protocolKeyword, IIdentifier name,
        IGenericParameterClause? genericParameterClause, ITypeInheritanceClause? typeInheritanceClause,
        IGenericWhereClause? genericConstraintsClause, LeftCurlyBrace membersStart, IProtocolMembers members,
        RightCurlyBrace membersEnd)
        : base(buffer, children)
    {
        Attributes = attributes;
        AccessLevelModifier = accessLevelModifier;
        ProtocolKeyword = protocolKeyword;
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

    public IReadOnlyList<IProtocolMember> MembersAsList => Members.Members;

    IReadOnlyAttributeGroup? IReadOnlyProtocolDeclaration.Attributes => Attributes;

    IReadOnlyAccessLevelModifier? IReadOnlyProtocolDeclaration.AccessLevelModifier => AccessLevelModifier;

    IReadOnlyIdentifier IReadOnlyProtocolDeclaration.Name => Name;

    IReadOnlyGenericParameterClause? IReadOnlyProtocolDeclaration.GenericParameterClause => GenericParameterClause;

    IReadOnlyTypeInheritanceClause? IReadOnlyProtocolDeclaration.TypeInheritanceClause => TypeInheritanceClause;

    IReadOnlyGenericWhereClause? IReadOnlyProtocolDeclaration.GenericConstraintsClause => GenericConstraintsClause;

    IReadOnlyProtocolMembers IReadOnlyProtocolDeclaration.Members => Members;

    IReadOnlyList<IReadOnlyProtocolMember> IReadOnlyProtocolDeclaration.MembersAsList => MembersAsList;

    public int Count => Members.Count;

    public bool IsReadOnly => false;

    public new IProtocolMember this[int index]
    {
        get => Members[index];
        set => Members[index] = value;
    }

    IReadOnlyProtocolMember IReadOnlyList<IReadOnlyProtocolMember>.this[int index]
        => Members[index];

    IReadOnlyProtocolMember IReadOnlyProtocolDeclaration.this[int index]
        => Members[index];

    public IEnumerator<IProtocolMember> GetEnumerator()
    {
        return Members.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyProtocolMember> IEnumerable<IReadOnlyProtocolMember>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IProtocolMember item)
    {
        return Members.Contains(item);
    }

    public int IndexOf(IProtocolMember item)
    {
        return Members.IndexOf(item);
    }

    public void CopyTo(IProtocolMember[] array, int arrayIndex)
    {
        Members.CopyTo(array, arrayIndex);
    }

    public void Add(IProtocolMember item)
    {
        Members.Add(item);
    }

    public void Clear()
    {
        Members.Clear();
    }

    public bool Remove(IProtocolMember item)
    {
        return Members.Remove(item);
    }

    public void Insert(int index, IProtocolMember item)
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

    public void ChangeMembers(IProtocolMembers newProtocolMembers)
    {
        throw new System.NotImplementedException();
    }
}