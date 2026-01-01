using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Types.ImplicitlyUnwrappedOptionalType;

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