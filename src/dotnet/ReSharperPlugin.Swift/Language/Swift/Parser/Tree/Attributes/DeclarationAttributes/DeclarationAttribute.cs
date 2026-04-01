using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes.DeclarationAttributes;

public abstract class DeclarationAttribute<TDeclaration> : Attribute where TDeclaration : Declaration
{
    public TDeclaration? Declaration { get; internal set; }

    protected DeclarationAttribute(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected DeclarationAttribute(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected DeclarationAttribute(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    protected DeclarationAttribute(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}
