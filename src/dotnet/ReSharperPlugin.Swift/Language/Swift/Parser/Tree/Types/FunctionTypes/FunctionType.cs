using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes;

public class FunctionType : TypeInternalNode
{
    public LeftParenthesis? LeftParenthesis { get; internal set; }
    
    public FunctionTypeArgumentList? FunctionTypeArgumentList { get; internal set; }
    
    public RightParenthesis? RightParenthesis { get; internal set; }
    
    public Ellipsis? Ellipsis { get; internal set; }
    
    public Async? Async { get; internal set; }
    
    public ThrowsClause? ThrowsClause { get; internal set; }
    
    public FunctionType(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public FunctionType(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public FunctionType(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public FunctionType(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}