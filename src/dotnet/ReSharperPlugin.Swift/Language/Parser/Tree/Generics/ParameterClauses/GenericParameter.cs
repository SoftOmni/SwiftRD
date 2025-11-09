using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Generics.ParameterClauses;

public class GenericParameter : SwiftInternalNode
{
    public GenericParameterGroup? GenericParameterGroup { get; internal set; }
    
    public Identifier? TypeName { get; internal set; }
    
    public Colon? Colon { get; internal set; }
    
    public IGenericTypeValue? GenericParameterValue { get; internal set; }

    public GenericParameter(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GenericParameter(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public GenericParameter(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public GenericParameter(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}