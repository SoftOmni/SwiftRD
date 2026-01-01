using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Attributes.DeclarationAttributes;

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
