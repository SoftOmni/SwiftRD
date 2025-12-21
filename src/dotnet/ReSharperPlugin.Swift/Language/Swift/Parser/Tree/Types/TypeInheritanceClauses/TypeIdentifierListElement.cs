using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types.TypeIdentifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.TypeInheritanceClauses;

public class TypeIdentifierListElement : SwiftInternalNode
{
    public AttributeGroup? AttributeGroup { get; internal set; }
    
    public TypeIdentifier? TypeIdentifier { get; internal set; }
    
    public TypeIdentifierListElement(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeIdentifierListElement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeIdentifierListElement(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public TypeIdentifierListElement(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}