using System.Collections.Generic;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations.Cases.UnionValues;

public class UnionStyleEnumerationMember : SwiftInternalNode
{
    public IUnionStyleEnumerationMember? Member { get; internal set; }
    
    public UnionStyleEnumerationMember(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public UnionStyleEnumerationMember(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public UnionStyleEnumerationMember(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public UnionStyleEnumerationMember(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}