using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;

public class WillSetDidSetBlock : SwiftInternalNode
{
    public WillSetClause? WillSet { get; internal set; }
    
    public DidSet? DidSet { get; internal set; }
    
    public WillSetDidSetBlock(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public WillSetDidSetBlock(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public WillSetDidSetBlock(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public WillSetDidSetBlock(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}