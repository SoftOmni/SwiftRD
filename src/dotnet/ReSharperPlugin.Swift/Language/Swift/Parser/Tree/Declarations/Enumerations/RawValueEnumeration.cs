using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations.Cases.RawValues;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations;

public class RawValueEnumeration : Enumeration
{
    public RawValueEnumerationMemberGroup? RawValueEnumerationMemberGroup { get; internal set; }
    
    public RawValueEnumeration(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public RawValueEnumeration(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public RawValueEnumeration(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public RawValueEnumeration(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}