using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.PrecedenceGroups;

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

    protected PrecedenceGroupAttribute(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    protected PrecedenceGroupAttribute(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}