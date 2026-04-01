using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;

public class GenericArgumentClause : SwiftInternalNode
{
    public LeftAngleBracket? LeftAngleBracket { get; internal set; }
    
    public GenericArgumentGroup? GenericArgumentGroup { get; internal set; }
    
    public RightAngleBracket? RightAngleBracket { get; internal set; }
    
    public GenericArgumentClause(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GenericArgumentClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GenericArgumentClause(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public GenericArgumentClause(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}