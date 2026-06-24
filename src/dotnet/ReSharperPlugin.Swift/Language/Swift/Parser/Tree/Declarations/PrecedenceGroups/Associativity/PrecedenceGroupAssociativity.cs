using System.Collections.Generic;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public class PrecedenceGroupAssociativity : PrecedenceGroupAttribute
{
    public Associativity? Associativity { get; internal set; }
    
    public Left? Left { get; internal set; }
    
    public Right? Right { get; internal set; }
    
    public None? None { get; internal set; }

    public PrecedenceGroupAssociativity(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrecedenceGroupAssociativity(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrecedenceGroupAssociativity(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public PrecedenceGroupAssociativity(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}