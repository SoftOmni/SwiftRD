using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.RawValues;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations;

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