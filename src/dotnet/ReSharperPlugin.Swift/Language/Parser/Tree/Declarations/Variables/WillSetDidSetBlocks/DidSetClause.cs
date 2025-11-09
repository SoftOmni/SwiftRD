using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.CodeBlocks;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;

public class DidSetClause : SwiftInternalNode
{
    public WillSetDidSetBlock? WillSetDidSetBlock { get; private set; }

    public List<Attribute> Attributes { get; private set; } = [];
    
    public DidSet? DidSet { get; internal set; }
    
    public SetterName? SetterName { get; internal set; }
    
    public CodeBlock? CodeBlock { get; internal set; }
    
    public DidSetClause(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public DidSetClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public DidSetClause(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public DidSetClause(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}