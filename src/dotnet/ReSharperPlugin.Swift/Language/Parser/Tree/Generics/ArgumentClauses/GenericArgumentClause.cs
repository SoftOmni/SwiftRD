using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Generics.ArgumentClauses;

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

    public GenericArgumentClause(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public GenericArgumentClause(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}