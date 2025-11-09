using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types;

public class TypeWithParenthesis : TypeInternalNode
{
    public LeftParenthesis? LeftParenthesis { get; internal set; }
    
    public IType? Type { get; internal set; }
    
    public RightParenthesis? RightParenthesis { get; internal set; }
    
    public TypeWithParenthesis(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeWithParenthesis(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeWithParenthesis(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public TypeWithParenthesis(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}