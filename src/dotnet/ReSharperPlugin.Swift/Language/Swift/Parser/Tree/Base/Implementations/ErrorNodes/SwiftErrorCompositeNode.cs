using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;

public abstract class SwiftErrorCompositeNode : SwiftErrorInternalNode<SwiftCompositeNode>
{
    protected SwiftErrorCompositeNode(IEditableBuffer buffer, string message)
        : base(buffer, message)
    { }

    protected SwiftErrorCompositeNode(SwiftCompositeNode parent, int index, IEditableBuffer editableBuffer, string message, IEnumerable<ISwiftNode<SwiftCompositeNode>>? children = null)
        : base(parent, index, editableBuffer, message, children)
    { }

    protected SwiftErrorCompositeNode(SwiftCompositeNode parent, int index, int textIndex, int lengthInParent, string message, IEnumerable<ISwiftNode<SwiftCompositeNode>>? children = null)
        : base(parent, index, textIndex, lengthInParent, message, children)
    { }

    protected SwiftErrorCompositeNode(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>?> children,
        string message)
        : base(buffer, FilterOutNullChildren(children), message)
    { }

    private static IEnumerable<ISwiftNode<SwiftCompositeNode>> FilterOutNullChildren(
        IEnumerable<ISwiftNode<SwiftCompositeNode>?> children)
    {
        List<ISwiftNode<SwiftCompositeNode>> list = [];

        foreach (ISwiftNode<SwiftCompositeNode>? child in children)
        {
            if (child is not null)
            {
                list.Add(child);
            }
        }

        return list;
    }
}