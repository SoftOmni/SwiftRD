using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions;

public class FunctionResult : SwiftInternalNode
{
    public FunctionSignature? FunctionSignature { get; private set; }
    
    public Arrow? Arrow { get; private set; }
    
    public AttributeGroup? AttributeGroup { get; private set; }
    
    public IType? Type { get; private set; }
    
    public FunctionResult(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public FunctionResult(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public FunctionResult(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public FunctionResult(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}