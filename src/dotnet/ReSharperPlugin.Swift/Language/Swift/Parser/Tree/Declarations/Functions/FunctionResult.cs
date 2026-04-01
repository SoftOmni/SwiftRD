using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;

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

    public FunctionResult(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public FunctionResult(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}