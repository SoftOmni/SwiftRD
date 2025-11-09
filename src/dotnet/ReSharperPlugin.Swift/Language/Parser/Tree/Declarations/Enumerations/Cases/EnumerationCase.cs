using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations.Cases;

public abstract class EnumerationCase : SwiftInternalNode
{
    public Identifier? Identifier { get; internal set; }

    protected EnumerationCase(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected EnumerationCase(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected EnumerationCase(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    protected EnumerationCase(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}