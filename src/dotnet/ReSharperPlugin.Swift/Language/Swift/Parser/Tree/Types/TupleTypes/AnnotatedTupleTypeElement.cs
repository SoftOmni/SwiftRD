using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TupleTypes;

public class AnnotatedTupleTypeElement : SwiftInternalNode, ITupleTypeElement
{
    public Identifier? Identifier { get; internal set; }
    
    public TypeAnnotation? TypeAnnotation { get; internal set; }

    public AnnotatedTupleTypeElement(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public AnnotatedTupleTypeElement(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public AnnotatedTupleTypeElement(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public AnnotatedTupleTypeElement(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}