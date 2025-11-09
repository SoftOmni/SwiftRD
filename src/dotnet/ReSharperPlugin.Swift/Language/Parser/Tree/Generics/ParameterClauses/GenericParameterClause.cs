using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Generics.ParameterClauses;

public class GenericParameterClause : SwiftInternalNode
{
    public LeftAngleBracket? LeftAngleBracket { get; internal set; }
    
    public RightAngleBracket? RightAngleBracket { get; internal set; }
    
    public GenericParameterGroup? GenericParameters { get; internal set; } 
    
    public GenericParameterClause(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GenericParameterClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GenericParameterClause(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public GenericParameterClause(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}