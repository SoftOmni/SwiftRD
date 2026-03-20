using System;
using System.Collections.Generic;

using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;

public partial interface IInternalNode
{
    /*public void ReplaceChildrenAt(int index, IEnumerable<INode> newNodes, bool extend = false);

    public void ReplaceChildrenAt(int index, IEnumerable<INode> newNodes, Action<INode> onChildDetachment,
        Action<INode> onChildAttachment, bool extend = false);

    public void ReplaceChildrenAt(int index, IEnumerable<INode> newNodes, int startInCollection, bool extend = false);

    public void ReplaceChildrenAt(int index, IEnumerable<INode> newNodes, int startInCollection,
        Action<INode> onChildDetachment,
        Action<INode> onChildAttachment, bool extend = false);

    public void ReplaceChildrenAt(int index, IEnumerable<INode> newNodes, int startInCollection, int endInCollection,
        bool extend = false);

    public void ReplaceChildrenAt(int index, IEnumerable<INode> newNodes, int startInCollection, int endInCollection,
        Action<INode> onChildDetachment, Action<INode> onChildAttachment, bool extend = false);

    public void ReplaceChildrenAt(int index, IList<INode> newNodes, bool extend = false);

    public void ReplaceChildrenAt(int index, IList<INode> newNodes, Action<INode> onChildDetachment,
        Action<INode> onChildAttachment,
        bool extend = false);

    public void ReplaceChildrenAt(int index, IList<INode> newNodes, int startInCollection, bool extend = false);

    public void ReplaceChildrenAt(int index, IList<INode> newNodes, int startInCollection,
        Action<INode> onChildDetachment,
        Action<INode> onChildAttachment, bool extend = false);

    public void ReplaceChildrenAt(int index, IList<INode> newNodes, int startInCollection, int endInCollection,
        bool extend = false);

    public void ReplaceChildrenAt(int index, IList<INode> newNodes, int startInCollection, int endInCollection,
        Action<INode> onChildDetachment, Action<INode> onChildAttachment, bool extend = false);

    public void ReplaceChildrenAt(int index, List<INode> newNodes, bool extend = false);

    public void ReplaceChildrenAt(int index, List<INode> newNodes, Action<INode> onChildDetachment,
        Action<INode> onChildAttachment,
        bool extend = false);

    public void ReplaceChildrenAt(int index, List<INode> newNodes, int startInCollection, bool extend = false);

    public void ReplaceChildrenAt(int index, List<INode> newNodes, int startInCollection,
        Action<INode> onChildDetachment,
        Action<INode> onChildAttachment, bool extend = false);

    public void ReplaceChildrenAt(int index, List<INode> newNodes, int startInCollection, int endInCollection,
        bool extend = false);

    public void ReplaceChildrenAt(int index, List<INode> newNodes, int startInCollection, int endInCollection,
        Action<INode> onChildDetachment, Action<INode> onChildAttachment, bool extend = false);

    public void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, bool extend = false)
        where TList : IList<TListElements> where TListElements : INode;

    public void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, Action<INode> onChildDetachment,
        Action<INode> onChildAttachment, bool extend = false)
        where TList : IList<TListElements> where TListElements : INode;

    public void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, int startInCollection,
        bool extend = false)
        where TList : IList<TListElements> where TListElements : INode;

    public void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, int startInCollection,
        Action<INode> onChildDetachment,
        Action<INode> onChildAttachment, bool extend = false)
        where TList : IList<TListElements> where TListElements : INode;

    public void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, int startInCollection,
        int endInCollection, bool extend = false)
        where TList : IList<TListElements> where TListElements : INode;

    public void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, int startInCollection,
        int endInCollection,
        Action<INode> onChildDetachment, Action<INode> onChildAttachment, bool extend = false)
        where TList : IList<TListElements> where TListElements : INode;*/
}