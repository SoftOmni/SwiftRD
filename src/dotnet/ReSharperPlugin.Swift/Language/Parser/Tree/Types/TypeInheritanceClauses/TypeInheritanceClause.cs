using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types.TypeIdentifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.TypeInheritanceClauses;

public class TypeInheritanceClause : SwiftInternalNode
{
    public Colon? Colon { get; internal set; }
    
    public TypeIdentifierList? TypeIdentifierGroup { get; internal set; }
    
    public TypeInheritanceClause(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeInheritanceClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeInheritanceClause(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public TypeInheritanceClause(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}