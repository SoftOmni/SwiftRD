using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;

public class ProtocolMetaType : MetaType
{
    public Protocol? Protocol { get; internal set; }
    
    public ProtocolMetaType(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ProtocolMetaType(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ProtocolMetaType(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public ProtocolMetaType(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}