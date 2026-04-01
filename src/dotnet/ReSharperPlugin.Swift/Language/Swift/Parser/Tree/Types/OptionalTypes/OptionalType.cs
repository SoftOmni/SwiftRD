using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.OptionalTypes;

public class OptionalType : TypeInternalNode
{
    public IType? Type { get; internal set; }
    
    public QuestionMark? QuestionMark { get; internal set; }

    public OptionalType(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public OptionalType(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public OptionalType(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public OptionalType(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}