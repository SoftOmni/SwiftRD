using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations.Cases.UnionValues;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Indirecterations;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Enumerations;

public class UnionStyleEnumeration : Enumeration
{
    public Indirect? Indirect { get; internal set; }
    
    public UnionStyleEnumerationMemberGroup? EnumerationMemberGroup { get; internal set; }
    
    public UnionStyleEnumeration(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public UnionStyleEnumeration(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public UnionStyleEnumeration(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public UnionStyleEnumeration(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}