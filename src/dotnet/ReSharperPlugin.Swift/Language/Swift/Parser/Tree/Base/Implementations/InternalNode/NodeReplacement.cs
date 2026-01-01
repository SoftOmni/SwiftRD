using System;
using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

public partial class SwiftInternalNode
{
    public void ReplaceChildrenAt(int index, IEnumerable<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        while (enumerator.MoveNext() && index < Children.Count)
        {
            AttachChild(index++, enumerator.Current!);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChild(enumerator.Current!);
        while (enumerator.MoveNext())
        {
            AppendChild(enumerator.Current!);
        }

        enumerator.Dispose();
    }

    public void ReplaceChildrenAt(int index, IEnumerable<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        while (enumerator.MoveNext() && index < Children.Count)
        {
            SetChildAt(index++, enumerator.Current!, onChildDetachment, onChildAttachment);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChild(enumerator.Current!, onChildAttachment);
        while (enumerator.MoveNext())
        {
            AppendChild(enumerator.Current!, onChildAttachment);
        }

        enumerator.Dispose();
    }

    public void ReplaceChildrenAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection, bool extend = false)
    {
        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        while (enumerator.MoveNext() && index < Children.Count)
        {
            AttachChild(index++, enumerator.Current!);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChild(enumerator.Current!);
        while (enumerator.MoveNext())
        {
            AppendChild(enumerator.Current!);
        }

        enumerator.Dispose();
    }

    internal void ReplaceChildrenAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        while (enumerator.MoveNext() && index < Children.Count)
        {
            SetChildAt(index++, enumerator.Current!, onChildDetachment, onChildAttachment);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChild(enumerator.Current!, onChildAttachment);
        while (enumerator.MoveNext())
        {
            AppendChild(enumerator.Current!, onChildAttachment);
        }

        enumerator.Dispose();
    }

    public void ReplaceChildrenAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection, int endInCollection, bool extend = false)
    {
        if (startInCollection == endInCollection)
        {
            return;
        }

        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> nodesToAdd = [enumerator.Current!];
        while (enumerator.MoveNext() && collectionIndex < endInCollection)
        {
            nodesToAdd.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        if (collectionIndex < endInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ReplaceChildrenAtUnderlying(index, nodesToAdd, 0, nodesToAdd.Count, extend);
    }

    internal void ReplaceChildrenAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (startInCollection == endInCollection)
        {
            return;
        }

        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> nodesToAdd = [enumerator.Current!];
        while (enumerator.MoveNext() && collectionIndex < endInCollection)
        {
            nodesToAdd.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        if (collectionIndex < endInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ReplaceChildrenAtUnderlying(index, nodesToAdd, 0, nodesToAdd.Count, onChildDetachment, onChildAttachment, extend);
    }

    public void ReplaceChildrenAt(int index, IList<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, 0, newNodes.Count, extend);
    }

    internal void ReplaceChildrenAt(int index, IList<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment,
        bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, 0, newNodes.Count, onChildDetachment, onChildAttachment, extend);
    }

    public void ReplaceChildrenAt(int index, IList<ISwiftNode> newNodes, int startInCollection, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, startInCollection + newNodes.Count, extend);
    }

    internal void ReplaceChildrenAt(int index, IList<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, startInCollection + newNodes.Count, onChildDetachment, onChildAttachment,
            extend);
    }

    public void ReplaceChildrenAt(int index, IList<ISwiftNode> newNodes, int startInCollection, int endInCollection, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, endInCollection, extend);
    }

    internal void ReplaceChildrenAt(int index, IList<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, endInCollection, onChildDetachment, onChildAttachment, extend);
    }

    public void ReplaceChildrenAt(int index, List<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, 0, newNodes.Count, extend);
    }

    internal void ReplaceChildrenAt(int index, List<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment,
        bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, 0, newNodes.Count, onChildDetachment, onChildAttachment, extend);
    }

    public void ReplaceChildrenAt(int index, List<ISwiftNode> newNodes, int startInCollection, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, startInCollection + newNodes.Count, extend);
    }

    internal void ReplaceChildrenAt(int index, List<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, startInCollection + newNodes.Count, onChildDetachment, onChildAttachment,
            extend);
    }

    public void ReplaceChildrenAt(int index, List<ISwiftNode> newNodes, int startInCollection, int endInCollection, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, endInCollection, extend);
    }

    internal void ReplaceChildrenAt(int index, List<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlying(index, newNodes, startInCollection, endInCollection, onChildDetachment, onChildAttachment, extend);
    }

    public void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlying<TList, TListElements>(index, newNodes, 0, newNodes.Count, extend);
    }

    internal void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlying<TList, TListElements>(index, newNodes, 0, newNodes.Count, onChildDetachment, onChildAttachment, extend);
    }

    public void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, int startInCollection, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlying<TList, TListElements>(index, newNodes, startInCollection, startInCollection + newNodes.Count, extend);
    }

    internal void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlying<TList, TListElements>(index, newNodes, startInCollection, startInCollection + newNodes.Count, onChildDetachment,
            onChildAttachment, extend);
    }

    public void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, int startInCollection, int endInCollection, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlying<TList, TListElements>(index, newNodes, startInCollection, endInCollection, extend);
    }

    internal void ReplaceChildrenAt<TList, TListElements>(int index, TList newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlying<TList, TListElements>(index, newNodes, startInCollection, endInCollection, onChildDetachment, onChildAttachment,
            extend);
    }

    private void ReplaceChildrenAtUnderlying(int index, IList<ISwiftNode> newNodes, int startInCollection, int endInCollection, bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildAt(placementIndex++, newNodes[startInCollection + i]);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChild(newNodes[startInCollection + target + i]);
        }
    }

    private void ReplaceChildrenAtUnderlying(int index, IList<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildAt(placementIndex++, newNodes[startInCollection + i], onChildDetachment, onChildAttachment);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChild(newNodes[startInCollection + target + i], onChildAttachment);
        }
    }

    private void ReplaceChildrenAtUnderlying(int index, List<ISwiftNode> newNodes, int startInCollection, int endInCollection, bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildAt(placementIndex++, newNodes[startInCollection + i]);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChild(newNodes[startInCollection + target + i]);
        }
    }

    private void ReplaceChildrenAtUnderlying(int index, List<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildAt(placementIndex++, newNodes[startInCollection + i], onChildDetachment, onChildAttachment);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChild(newNodes[startInCollection + target + i], onChildAttachment);
        }
    }

    private void ReplaceChildrenAtUnderlying<TList, TListElements>(int index, TList newNodes, int startInCollection, int endInCollection,
        bool extend = false) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildAt(placementIndex++, newNodes[startInCollection + i]);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChild(newNodes[startInCollection + target + i]);
        }
    }

    private void ReplaceChildrenAtUnderlying<TList, TListElements>(int index, TList newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildAt(placementIndex++, newNodes[startInCollection + i], onChildDetachment, onChildAttachment);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChild(newNodes[startInCollection + target + i], onChildAttachment);
        }
    }

    internal void ReplaceChildrenForciblyAt(int index, IEnumerable<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        while (enumerator.MoveNext() && index < Children.Count)
        {
            AttachChildForcibly(index++, enumerator.Current!);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChildForcibly(enumerator.Current!);
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!);
        }

        enumerator.Dispose();
    }

    internal void ReplaceChildrenForciblyAt(int index, IEnumerable<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        while (enumerator.MoveNext() && index < Children.Count)
        {
            SetChildForciblyAt(index++, enumerator.Current!, onChildDetachment, onChildAttachment);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChildForcibly(enumerator.Current!, onChildAttachment);
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!, onChildAttachment);
        }

        enumerator.Dispose();
    }

    internal void ReplaceChildrenForciblyAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection, bool extend = false)
    {
        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        while (enumerator.MoveNext() && index < Children.Count)
        {
            AttachChildForcibly(index++, enumerator.Current!);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChildForcibly(enumerator.Current!);
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!);
        }

        enumerator.Dispose();
    }

    internal void ReplaceChildrenForciblyAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        while (enumerator.MoveNext() && index < Children.Count)
        {
            SetChildForciblyAt(index++, enumerator.Current!, onChildDetachment, onChildAttachment);
        }

        if (index < Children.Count || !extend)
        {
            enumerator.Dispose();
            return;
        }

        AppendChildForcibly(enumerator.Current!, onChildAttachment);
        while (enumerator.MoveNext())
        {
            AppendChildForcibly(enumerator.Current!, onChildAttachment);
        }

        enumerator.Dispose();
    }

    internal void ReplaceChildrenForciblyAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        bool extend = false)
    {
        if (startInCollection == endInCollection)
        {
            return;
        }

        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> nodesToAdd = [enumerator.Current!];
        while (enumerator.MoveNext() && collectionIndex < endInCollection)
        {
            nodesToAdd.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        if (collectionIndex < endInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, nodesToAdd, 0, nodesToAdd.Count, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IEnumerable<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (startInCollection == endInCollection)
        {
            return;
        }

        if (startInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (endInCollection < startInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (index < 0 || index > Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        IEnumerator<ISwiftNode> enumerator = newNodes.GetEnumerator();
        int collectionIndex = 0;
        while (enumerator.MoveNext() && collectionIndex < startInCollection)
        {
            collectionIndex++;
        }

        if (collectionIndex < startInCollection)
        {
            enumerator.Dispose();
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        List<ISwiftNode> nodesToAdd = [enumerator.Current!];
        while (enumerator.MoveNext() && collectionIndex < endInCollection)
        {
            nodesToAdd.Add(enumerator.Current!);
        }

        enumerator.Dispose();
        if (collectionIndex < endInCollection)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, nodesToAdd, 0, nodesToAdd.Count, onChildDetachment, onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IList<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, 0, newNodes.Count, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IList<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, 0, newNodes.Count, onChildDetachment, onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IList<ISwiftNode> newNodes, int startInCollection, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, startInCollection + newNodes.Count, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IList<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, startInCollection + newNodes.Count, onChildDetachment,
            onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IList<ISwiftNode> newNodes, int startInCollection, int endInCollection, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, endInCollection, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, IList<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, endInCollection, onChildDetachment, onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, List<ISwiftNode> newNodes, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, 0, newNodes.Count, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, List<ISwiftNode> newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, 0, newNodes.Count, onChildDetachment, onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, List<ISwiftNode> newNodes, int startInCollection, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, startInCollection + newNodes.Count, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, List<ISwiftNode> newNodes, int startInCollection, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, startInCollection + newNodes.Count, onChildDetachment,
            onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, List<ISwiftNode> newNodes, int startInCollection, int endInCollection, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, endInCollection, extend);
    }

    internal void ReplaceChildrenForciblyAt(int index, List<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlyingForcibly(index, newNodes, startInCollection, endInCollection, onChildDetachment, onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt<TList, TListElements>(int index, TList newNodes, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(index, newNodes, 0, newNodes.Count, extend);
    }

    internal void ReplaceChildrenForciblyAt<TList, TListElements>(int index, TList newNodes, Action<ISwiftNode> onChildDetachment,
        Action<ISwiftNode> onChildAttachment, bool extend = false) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(index, newNodes, 0, newNodes.Count, onChildDetachment, onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt<TList, TListElements>(int index, TList newNodes, int startInCollection, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(index, newNodes, startInCollection, startInCollection + newNodes.Count, extend);
    }

    internal void ReplaceChildrenForciblyAt<TList, TListElements>(int index, TList newNodes, int startInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(index, newNodes, startInCollection, startInCollection + newNodes.Count,
            onChildDetachment, onChildAttachment, extend);
    }

    internal void ReplaceChildrenForciblyAt<TList, TListElements>(int index, TList newNodes, int startInCollection, int endInCollection,
        bool extend = false) where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(index, newNodes, startInCollection, endInCollection, extend);
    }

    internal void ReplaceChildrenForciblyAt<TList, TListElements>(int index, TList newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        if (index < 0 || index >= Children.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(index));
        }

        if (startInCollection < 0 || startInCollection >= newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(startInCollection));
        }

        if (endInCollection < startInCollection || endInCollection > newNodes.Count)
        {
            throw new ArgumentOutOfRangeException(nameof(endInCollection));
        }

        if (startInCollection > endInCollection)
        {
            throw new ArgumentException("startInCollection must be less than or equal to endInCollection");
        }

        ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(index, newNodes, startInCollection, endInCollection, onChildDetachment,
            onChildAttachment, extend);
    }

    private void ReplaceChildrenAtUnderlyingForcibly(int index, IList<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            AttachChildForcibly(placementIndex++, newNodes[startInCollection + i]);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChildForcibly(newNodes[startInCollection + target + i]);
        }
    }

    private void ReplaceChildrenAtUnderlyingForcibly(int index, IList<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildForciblyAt(placementIndex++, newNodes[startInCollection + i], onChildDetachment, onChildAttachment);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChildForcibly(newNodes[startInCollection + target + i], onChildAttachment);
        }
    }

    private void ReplaceChildrenAtUnderlyingForcibly(int index, List<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            AttachChildForcibly(placementIndex++, newNodes[startInCollection + i]);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChildForcibly(newNodes[startInCollection + target + i]);
        }
    }

    private void ReplaceChildrenAtUnderlyingForcibly(int index, List<ISwiftNode> newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildForciblyAt(placementIndex++, newNodes[startInCollection + i], onChildDetachment, onChildAttachment);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChildForcibly(newNodes[startInCollection + target + i], onChildAttachment);
        }
    }

    private void ReplaceChildrenAtUnderlyingForcibly<TList, TListElement>(int index, TList newNodes, int startInCollection, int endInCollection,
        bool extend = false) where TList : IList<TListElement> where TListElement : ISwiftNode
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildForciblyAt(placementIndex++, newNodes[startInCollection + i]);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChildForcibly(newNodes[startInCollection + target + i]);
        }
    }

    private void ReplaceChildrenAtUnderlyingForcibly<TList, TListElements>(int index, TList newNodes, int startInCollection, int endInCollection,
        Action<ISwiftNode> onChildDetachment, Action<ISwiftNode> onChildAttachment, bool extend = false)
        where TList : IList<TListElements> where TListElements : ISwiftNode
    {
        int length = endInCollection - startInCollection;
        int target = Math.Min(length, Children.Count - index);

        int placementIndex = index;
        for (int i = 0; i < target; i++)
        {
            SetChildForciblyAt(placementIndex++, newNodes[startInCollection + i], onChildDetachment, onChildAttachment);
        }

        if (!extend)
        {
            return;
        }

        int remaining = length - target;
        for (int i = 0; i < remaining; i++)
        {
            AppendChildForcibly(newNodes[startInCollection + target + i], onChildAttachment);
        }
    }
}