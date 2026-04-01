using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.ClojureParameterLists;

public class ClosureParameter : SwiftInternalNode
{
    public Identifier? Identifier { get; internal set; }
    
    public TypeAnnotation? TypeAnnotation { get; internal set; }
    
    public Ellipsis? Ellipsis { get; internal set; }
    
    public ClosureParameter(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ClosureParameter(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public ClosureParameter(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public ClosureParameter(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}