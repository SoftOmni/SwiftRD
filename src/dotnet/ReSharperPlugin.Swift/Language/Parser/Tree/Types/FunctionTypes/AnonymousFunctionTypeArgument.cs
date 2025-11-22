using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.FunctionTypes;

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