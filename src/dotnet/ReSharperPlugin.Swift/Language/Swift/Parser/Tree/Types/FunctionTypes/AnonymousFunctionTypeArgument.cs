using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes;

public class AnonymousFunctionTypeArgument : FunctionTypeArgument
{
    public AttributeGroup? AttributeGroup { get; internal set; }
    
    public ParameterModifier? ParameterModifier { get; internal set; }
    
    public IType? Type { get; internal set; }
    
    public AnonymousFunctionTypeArgument(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public AnonymousFunctionTypeArgument(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public AnonymousFunctionTypeArgument(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public AnonymousFunctionTypeArgument(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}