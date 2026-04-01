using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

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

    public TypeInheritanceClause(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public TypeInheritanceClause(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}