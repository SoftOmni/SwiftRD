using System.Collections.Generic;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.OpaqueTypes;

public class OpaqueType : TypeInternalNode
{
    public Some? Some { get; internal set; }
    
    public IType? Type { get; internal set; }
    
    public OpaqueType(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public OpaqueType(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public OpaqueType(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public OpaqueType(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}