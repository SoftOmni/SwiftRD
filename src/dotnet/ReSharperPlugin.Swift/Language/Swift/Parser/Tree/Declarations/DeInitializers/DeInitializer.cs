using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeInitializers;

public class DeInitializer : Declaration
{
    public AttributeGroup? AttributeGroup { get; internal set; }
    
    public DeInit? DeInit { get; internal set; }
    
    public CodeBlock? CodeBlock { get; internal set; }
    
    public DeInitializer(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public DeInitializer(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public DeInitializer(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public DeInitializer(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}