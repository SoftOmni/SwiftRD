using System.Collections;
using System.Collections.Generic;
using JetBrains.Application.UI.Icons.CompiledIcons;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;
using SoftOmni.SwiftRd.Resources.Icons.Language;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Classes;

public class ClassDeclaration : SwiftCompositeNode, IClassDeclaration
{
    public IAttributeGroup? Attributes { get; }

    public IAccessLevelModifier? AccessLevelModifier { get; }

    public Final? FinalKeyword { get; }

    public Class ClassKeyword { get; }

    public IIdentifier Name { get; }

    public IGenericParameterClause? GenericParameterClause { get; }

    public ITypeInheritanceClause? TypeInheritanceClause { get; }

    public IGenericWhereClause? GenericConstraintsClause { get; }

    public LeftCurlyBrace MembersStart { get; }

    public IClassMembers Members { get; }

    public RightCurlyBrace MembersEnd { get; }

    internal ClassDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup? attributes, IAccessLevelModifier? accessLevelModifier, Class classKeyword, Final? finalKeyword,
        IIdentifier name,
        IGenericParameterClause? genericParameterClause, ITypeInheritanceClause? typeInheritanceClause,
        IGenericWhereClause? genericConstraintsClause, LeftCurlyBrace membersStart, IClassMembers members,
        RightCurlyBrace membersEnd)
        : base(buffer, children)
    {
        Attributes = attributes;
        AccessLevelModifier = accessLevelModifier;
        ClassKeyword = classKeyword;
        Name = name;
        GenericParameterClause = genericParameterClause;
        TypeInheritanceClause = typeInheritanceClause;
        GenericConstraintsClause = genericConstraintsClause;
        MembersStart = membersStart;
        Members = members;
        MembersEnd = membersEnd;
        FinalKeyword = finalKeyword;

        Icon = SwiftIcons.ConstantIcon;
    }

    public AnyCompiledIconClass Icon { get; }

    public IReadOnlyList<IClassMember> MembersAsList => Members.Members;

    IReadOnlyAttributeGroup? IReadOnlyClassDeclaration.Attributes => Attributes;

    IReadOnlyAccessLevelModifier? IReadOnlyClassDeclaration.AccessLevelModifier => AccessLevelModifier;

    IReadOnlyIdentifier IReadOnlyClassDeclaration.Name => Name;

    IReadOnlyGenericParameterClause? IReadOnlyClassDeclaration.GenericParameterClause => GenericParameterClause;

    IReadOnlyTypeInheritanceClause? IReadOnlyClassDeclaration.TypeInheritanceClause => TypeInheritanceClause;

    IReadOnlyGenericWhereClause? IReadOnlyClassDeclaration.GenericConstraintsClause => GenericConstraintsClause;

    IReadOnlyClassMembers IReadOnlyClassDeclaration.Members => Members;

    IReadOnlyList<IReadOnlyClassMember> IReadOnlyClassDeclaration.MembersAsList => MembersAsList;

    public int Count => Members.Count;

    public bool IsReadOnly => false;

    public new IClassMember this[int index]
    {
        get => Members[index];
        set => Members[index] = value;
    }

    IReadOnlyClassMember IReadOnlyList<IReadOnlyClassMember>.this[int index]
        => Members[index];

    IReadOnlyClassMember IReadOnlyClassDeclaration.this[int index]
        => Members[index];

    public IEnumerator<IClassMember> GetEnumerator()
    {
        return Members.GetEnumerator();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    IEnumerator<IReadOnlyClassMember> IEnumerable<IReadOnlyClassMember>.GetEnumerator()
    {
        return GetEnumerator();
    }

    public bool Contains(IClassMember item)
    {
        return Members.Contains(item);
    }

    public int IndexOf(IClassMember item)
    {
        return Members.IndexOf(item);
    }

    public void CopyTo(IClassMember[] array, int arrayIndex)
    {
        Members.CopyTo(array, arrayIndex);
    }

    public void Add(IClassMember item)
    {
        Members.Add(item);
    }

    public void Clear()
    {
        Members.Clear();
    }

    public bool Remove(IClassMember item)
    {
        return Members.Remove(item);
    }

    public void Insert(int index, IClassMember item)
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

    public void ChangeMembers(IClassMembers newClassMembers)
    {
        throw new System.NotImplementedException();
    }
}
