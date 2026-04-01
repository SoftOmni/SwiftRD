using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

public class TypeAnnotation : SwiftInternalNode
{
    public Colon? Colon { get; internal set; }

    public AttributeGroup? AttributeGroup { get; internal set; }

    public IType? Type { get; internal set; }

    public TypeAnnotation(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeAnnotation(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeAnnotation(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public TypeAnnotation(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}