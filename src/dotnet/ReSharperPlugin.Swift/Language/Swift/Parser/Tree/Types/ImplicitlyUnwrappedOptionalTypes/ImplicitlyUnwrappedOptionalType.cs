using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ImplicitlyUnwrappedOptionalType;

public class ImplicitlyUnwrappedOptionalType : TypeInternalNode
{
    public IType? Type { get; internal set; }
    
    public ExclamationMark? ExclamationMark { get; internal set; }
    
    public ImplicitlyUnwrappedOptionalType(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ImplicitlyUnwrappedOptionalType(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public ImplicitlyUnwrappedOptionalType(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public ImplicitlyUnwrappedOptionalType(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}