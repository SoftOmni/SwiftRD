using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes;

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

    public LabeledFunctionTypeArgument(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public LabeledFunctionTypeArgument(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}