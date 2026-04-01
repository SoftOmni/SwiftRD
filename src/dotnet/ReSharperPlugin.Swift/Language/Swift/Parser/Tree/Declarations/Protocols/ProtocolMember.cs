using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;

public abstract class ProtocolMember : SwiftInternalNode
{
    public Protocol? Protocol { get; internal set; }
    
    public ProtocolMemberGroup? MemberGroup { get; internal set; }
    
    protected ProtocolMember(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected ProtocolMember(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected ProtocolMember(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    protected ProtocolMember(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}