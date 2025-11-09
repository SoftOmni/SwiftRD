using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.FunctionTypes;

public class ThrowsClause : SwiftInternalNode
{
    public FunctionType? FunctionType { get; internal set; }
    
    public Throws? Throws { get; internal set; }
    
    public LeftParenthesis? LeftParenthesis { get; internal set; }
    
    public IType? Type { get; internal set; }
    
    public RightParenthesis? RightParenthesis { get; internal set; }

    public ThrowsClause(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ThrowsClause(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ThrowsClause(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public ThrowsClause(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}