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

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Actorures;

public class ActorDeclaration : SwiftCompositeNode, IActorDeclaration
{
    public IAttributeGroup? Attributes { get; }

    public IAccessLevelModifier? AccessLevelModifier { get; }

    public Actor ActorKeyword { get; }

    public IIdentifier Name { get; }

    public IGenericParameterClause? GenericParameterClause { get; }

    public ITypeInheritanceClause? TypeInheritanceClause { get; }

    public IGenericWhereClause? GenericConstraintsClause { get; }

    public LeftCurlyBrace MembersStart { get; }

    public IActorMembers Members { get; }

    public RightCurlyBrace MembersEnd { get; }

    internal ActorDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IAccessLevelModifier? accessLevelModifier, Actor actorKeyword, IIdentifier name,
        IGenericParameterClause? genericParameterClause, ITypeInheritanceClause? typeInheritanceClause,
        IGenericWhereClause? genericConstraintsClause, LeftCurlyBrace membersStart, IActorMembers members,
        RightCurlyBrace membersEnd)
        : base(buffer, children)
    {
        Attributes = attributes;
        AccessLevelModifier = accessLevelModifier;
        ActorKeyword = actorKeyword;
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

    public IReadOnlyList<IActorMember> MembersAsList => Members.Members;

    IReadOnlyAttributeGroup? IReadOnlyActorDeclaration.Attributes => Attributes;

    IReadOnlyAccessLevelModifier? IReadOnlyActorDeclaration.AccessLevelModifier => AccessLevelModifier;

    IReadOnlyIdentifier IReadOnlyActorDeclaration.Name => Name;

    IReadOnlyGenericParameterClause? IReadOnlyActorDeclaration.GenericParameterClause => GenericParameterClause;

    IReadOnlyTypeInheritanceClause? IReadOnlyActorDeclaration.TypeInheritanceClause => TypeInheritanceClause;

    IReadOnlyGenericWhereClause? IReadOnlyActorDeclaration.GenericConstraintsClause => GenericConstraintsClause;

    IReadOnlyActorMembers IReadOnlyActorDeclaration.Members => Members;

    IReadOnlyList<IReadOnlyActorMember> IReadOnlyActorDeclaration.MembersAsList => MembersAsList;

    public int Count => Members.Count;

    public bool IsReadOnly => false;

    public new IActorMember this[int index]
    {
        get => Members[index];
        set => Members[index] = value;
    }

    IReadOnlyActorMember IReadOnlyList<IReadOnlyActorMember>.this[int index]
        => Members[index];

    IReadOnlyActorMember IReadOnlyActorDeclaration.this[int index]
        => Members[index];

    public IEnumerator<IActorMember> GetEnumerator()
    {
        return Members.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyActorMember> IEnumerable<IReadOnlyActorMember>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IActorMember item)
    {
        return Members.Contains(item);
    }

    public int IndexOf(IActorMember item)
    {
        return Members.IndexOf(item);
    }

    public void CopyTo(IActorMember[] array, int arrayIndex)
    {
        Members.CopyTo(array, arrayIndex);
    }

    public void Add(IActorMember item)
    {
        Members.Add(item);
    }

    public void Clear()
    {
        Members.Clear();
    }

    public bool Remove(IActorMember item)
    {
        return Members.Remove(item);
    }

    public void Insert(int index, IActorMember item)
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

    public void ChangeMembers(IActorMembers newActorMembers)
    {
        throw new System.NotImplementedException();
    }
}