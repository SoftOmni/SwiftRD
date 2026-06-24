using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Rider.Language.Parser.Tree.Generics.WhereClauses;

public class SameTypeRequirement : Requirement
{
    public Equal? Equal { get; internal set; }
    
    public IType? EqualedType { get; internal set; }
    
    public SameTypeRequirement(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public SameTypeRequirement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public SameTypeRequirement(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public SameTypeRequirement(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}