using System.Collections.Generic;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Marker;

public abstract class EmptyInternal : SwiftCompositeNode, IMarker
{
    protected EmptyInternal(IEditableBuffer buffer)
        : base(buffer)
    { }

    protected EmptyInternal(SwiftCompositeNode parent, int index, IEditableBuffer editableBuffer, IEnumerable<ISwiftNode<SwiftCompositeNode>>? children = null)
        : base(parent, index, editableBuffer, children)
    { }

    protected EmptyInternal(SwiftCompositeNode parent, int index, int textIndex, int lengthInParent, IEnumerable<ISwiftNode<SwiftCompositeNode>>? children = null)
        : base(parent, index, textIndex, lengthInParent, children)
    { }

    protected EmptyInternal(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children)
        : base(buffer, children)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Empty;
}