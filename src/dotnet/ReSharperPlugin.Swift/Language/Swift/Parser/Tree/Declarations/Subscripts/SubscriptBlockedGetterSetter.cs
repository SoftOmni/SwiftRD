using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Blocks;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Subscripts;

public class SubscriptBlockedGetterSetter : Subscript
{
    public BlockedGetterSetterBlock? GetterSetterBlock { get; internal set; }
    
    public SubscriptBlockedGetterSetter(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SubscriptBlockedGetterSetter(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SubscriptBlockedGetterSetter(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public SubscriptBlockedGetterSetter(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}