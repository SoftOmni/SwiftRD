using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

public class TypeAnnotation : SwiftCompositeNode, ITypeAnnotation
{
    public Colon Colon { get; }

    public IAttributeGroup? AttributeGroup { get; internal set; }

    public IType Type { get; internal set; }

    internal TypeAnnotation(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Colon colon, IType type)
        : base(buffer, children)
    {
        Colon = colon;
        Type = type;
    }
    
    internal TypeAnnotation(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Colon colon, IAttributeGroup attributeGroup, IType type)
        : base(buffer, children)
    {
        Colon = colon;
        AttributeGroup = attributeGroup;
        Type = type;
    }

    IReadOnlyAttributeGroup? IReadOnlyTypeAnnotation.AttributeGroup => AttributeGroup;

    IReadOnlyType IReadOnlyTypeAnnotation.Type => Type;
    
    public void ChangeType(IType type)
    {
        throw new NotImplementedException();
    }
}
