using System;
using System.Collections.Generic;

using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;

public partial interface IInternalNode
{
    /// <summary>
    ///     <para>
    ///         Make the <see cref="INode"/> child at index <paramref name="index"/> a new <see cref="INode"/> node of its own tree.
    ///         This will remove the child as a child of this <see cref="INode"/>. That <see cref="INode"/> will no longer have a parent
    ///         (returned from <see cref="INode.GetParent"/>).
    ///     </para>
    /// </summary>
    /// <param name="index">
    ///     The index of the child to remove in the <see cref="List{T}"/>-like (or <see cref="Array"/>-like) structure containing the children.
    ///  // TODO: review this wording
    /// </param>
    /// <returns>
    ///     The <see cref="INode"/> that has been detached and made a root of its own tree.
    /// </returns>
    public INode DetachChildAt(int index);

    public TNode DetachChildAt<TNode>(int index) where TNode : INode;

    public INode DetachChildAt(int index, Action<INode> onChildDetachment);

    public TNode DetachChildAt<TNode>(int index, Action<INode> onChildDetachment) where TNode : INode;

    public void DetachChildAtAndDiscard(int index);

    public void DetachChildAtAndDiscard<TNode>(int index) where TNode : INode;
    
    public void DetachChildAtAndDiscard(int index, Action<INode> onChildDetachment);
}