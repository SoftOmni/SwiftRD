using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;
using IOperator = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages.IOperator;
using IReadOnlyOperator = SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Usages.IReadOnlyOperator;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

public class TypeIdentifierListElement : SwiftCompositeNode, ITypeInheritanceListElement
{
    public IAttributeGroup? AttributeGroup { get; }
    
    public IOperator? Tilde { get; }
    
    public ITypeIdentifier TypeIdentifier { get; }

    internal TypeIdentifierListElement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        ITypeIdentifier typeIdentifier)
        : base(buffer, children)
    {
        AttributeGroup = null;
        Tilde = null;
        TypeIdentifier = typeIdentifier;
    }

    internal TypeIdentifierListElement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup attributeGroup, ITypeIdentifier typeIdentifier)
        : base(buffer, children)
    {
        AttributeGroup = attributeGroup;
        Tilde = null;
        TypeIdentifier = typeIdentifier;
    }

    internal TypeIdentifierListElement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IOperator @operator, ITypeIdentifier typeIdentifier)
        : base(buffer, children)
    {
        AttributeGroup = null;
        Tilde = @operator;
        TypeIdentifier = typeIdentifier;
    }

    internal TypeIdentifierListElement(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IAttributeGroup attributeGroup, IOperator @operator, ITypeIdentifier typeIdentifier)
        : base(buffer, children)
    {
        AttributeGroup = attributeGroup;
        Tilde = @operator;
        TypeIdentifier = typeIdentifier;
    }

    IReadOnlyAttributeGroup? IReadOnlyTypeInheritanceListElement.AttributeGroup => AttributeGroup;

    IReadOnlyOperator? IReadOnlyTypeInheritanceListElement.Tilde => Tilde;

    IReadOnlyTypeIdentifier IReadOnlyTypeInheritanceListElement.TypeIdentifier => TypeIdentifier;

    public bool AddIfNotPresentAttributeGroup(IAttributeGroup attributeGroup)
    {
        throw new NotImplementedException();
    }

    public void SetAttributeGroupTo(IAttributeGroup? attributeGroup)
    {
        throw new NotImplementedException();
    }

    public void RemoveAttributeGroup()
    {
        throw new NotImplementedException();
    }

    public void AddTildeIfNotPresent()
    {
        throw new NotImplementedException();
    }

    public void RemoveTilde()
    {
        throw new NotImplementedException();
    }

    public void ChangeTypeIdentifier(ITypeIdentifier typeIdentifier)
    {
        throw new NotImplementedException();
    }
}