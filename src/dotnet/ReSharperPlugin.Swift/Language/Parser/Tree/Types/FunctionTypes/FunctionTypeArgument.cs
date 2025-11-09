using System.Collections.Generic;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.FunctionTypes;

public abstract class FunctionTypeArgument : SwiftInternalNode
{
    public FunctionType? FunctionType { get; internal set; }
    
    public FunctionTypeArgumentList? ArgumentList { get; internal set; }

    protected FunctionTypeArgument(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected FunctionTypeArgument(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected FunctionTypeArgument(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    protected FunctionTypeArgument(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}