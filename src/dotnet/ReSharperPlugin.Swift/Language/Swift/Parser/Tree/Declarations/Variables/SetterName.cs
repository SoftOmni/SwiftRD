using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;

public class SetterName : SwiftInternalNode
{
    public LeftParenthesis? LeftParenthesis { get; private set; }
    
    public Identifier? Identifier { get; private set; }
    
    public RightParenthesis? RightParenthesis { get; private set; }
    
    public SetterName(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public SetterName(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public SetterName(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public SetterName(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}