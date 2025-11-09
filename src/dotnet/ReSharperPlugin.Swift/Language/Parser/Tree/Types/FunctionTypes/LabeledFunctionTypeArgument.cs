using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.FunctionTypes;

public class LabeledFunctionTypeArgument : FunctionTypeArgument
{
    public Identifier? Identifier { get; internal set; }
    
    public TypeAnnotation? TypeAnnotation { get; internal set; }
    
    public LabeledFunctionTypeArgument(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public LabeledFunctionTypeArgument(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public LabeledFunctionTypeArgument(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public LabeledFunctionTypeArgument(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}