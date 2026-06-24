using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups;

public abstract class PrecedenceGroupAttribute : SwiftInternalNode
{
    public PrecedenceGroupAttributeGroup? PrecedenceGroupAttributeGroup { get; internal set; }
    
    public Colon? Colon { get; internal set; }
    
    protected PrecedenceGroupAttribute(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected PrecedenceGroupAttribute(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    protected PrecedenceGroupAttribute(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    protected PrecedenceGroupAttribute(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}