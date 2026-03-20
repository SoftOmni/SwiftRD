using System;
using System.Collections;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;
using ReSharperPlugin.Swift.Technology.Exceptions;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public struct LooseEnumerator : IEnumerator<INode>
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public LooseEnumerator(InternalNode internalNode)
        {
            InternalNode = internalNode;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
        }

        public LooseEnumerator(InternalNode internalNode, int startIndex)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = internalNode.NumberOfChildren;
        }

        public LooseEnumerator(InternalNode internalNode, int startIndex, int endIndex)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < startIndex || endIndex > internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = endIndex;
        }

        public void Dispose()
        {
            // Nothing to do
        }

        public bool MoveNext()
        {
            if (ChildIndex >= ChildIndexEnd)
            {
                return false;
            }

            ChildIndex++;
            return true;
        }

        public void Reset()
        {
            ChildIndex = ChildIndexStart - 1;
        }

        public INode Current => ChildIndex < ChildIndexStart
            ? throw new EnumeratorInInitialPositionException()
            : InternalNode.GetChildAt(ChildIndex);

        object IEnumerator.Current => Current;
    }

    public struct LooseEnumeratorWithAction : IEnumerator<INode>, IWithActionOnChildRetrievalLoose
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public Action<INode> OnChildRetrieval { get; private set; }

        public LooseEnumeratorWithAction(InternalNode internalNode, Action<INode> onChildRetrieval)
        {
            InternalNode = internalNode;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
            OnChildRetrieval = onChildRetrieval;
        }

        public LooseEnumeratorWithAction(InternalNode internalNode, int startIndex, Action<INode> onChildRetrieval)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = internalNode.NumberOfChildren;
            OnChildRetrieval = onChildRetrieval;
        }

        public LooseEnumeratorWithAction(InternalNode internalNode, int startIndex, int endIndex,
            Action<INode> onChildRetrieval)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < startIndex || endIndex > internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = endIndex;
            OnChildRetrieval = onChildRetrieval;
        }

        public void Dispose()
        {
            // Nothing to do
        }

        public bool MoveNext()
        {
            if (ChildIndex >= ChildIndexEnd)
            {
                return false;
            }

            ChildIndex++;
            return true;
        }

        public void Reset()
        {
            ChildIndex = ChildIndexStart - 1;
        }

        public INode Current
        {
            get
            {
                if (ChildIndex < ChildIndexStart)
                    throw new EnumeratorInInitialPositionException();

                OnChildRetrieval(InternalNode._children[ChildIndex]);
                return InternalNode._children[ChildIndex];
            }
        }

        object IEnumerator.Current => Current;

        public void SetChildRetrievalAction(Action<INode> node)
        {
            OnChildRetrieval = node;
        }
    }

    public struct LooseEnumeratorWithSimplePredicate : IEnumerator<INode>
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public Func<INode, bool> Predicate { get; }

        public LooseEnumeratorWithSimplePredicate(InternalNode internalNode, Func<INode, bool> predicate)
        {
            InternalNode = internalNode;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
        }

        public LooseEnumeratorWithSimplePredicate(InternalNode internalNode, int startIndex,
            Func<INode, bool> predicate)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
        }

        public LooseEnumeratorWithSimplePredicate(InternalNode internalNode, int startIndex, int endIndex,
            Func<INode, bool> predicate)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < startIndex || endIndex > internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = endIndex;
            Predicate = predicate;
        }

        public void Dispose()
        {
            // Nothing to do
        }

        public bool MoveNext()
        {
            while (ChildIndex >= ChildIndexEnd && !Predicate(InternalNode._children[ChildIndex]))
            {
                ChildIndex++;
            }

            return ChildIndex < ChildIndexEnd;
        }

        public void Reset()
        {
            ChildIndex = ChildIndexStart - 1;
        }

        public INode Current => ChildIndex < ChildIndexStart
            ? throw new EnumeratorInInitialPositionException()
            : InternalNode.GetLooseChildAt(ChildIndex);

        object IEnumerator.Current => Current;
    }

    public struct LooseEnumeratorWithSimplePredicateWithAction : IEnumerator<INode>, IWithActionOnChildRetrievalLoose
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public Func<INode, bool> Predicate { get; }

        public Action<INode> OnChildRetrieval { get; private set; }

        public LooseEnumeratorWithSimplePredicateWithAction(InternalNode internalNode, Func<INode, bool> predicate,
            Action<INode> onChildRetrieval)
        {
            InternalNode = internalNode;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public LooseEnumeratorWithSimplePredicateWithAction(InternalNode internalNode, int startIndex,
            Func<INode, bool> predicate, Action<INode> onChildRetrieval)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public LooseEnumeratorWithSimplePredicateWithAction(InternalNode internalNode, int startIndex, int endIndex,
            Func<INode, bool> predicate, Action<INode> onChildRetrieval)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < startIndex || endIndex > internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = endIndex;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public void Dispose()
        {
            // Nothing to do
        }

        public bool MoveNext()
        {
            while (ChildIndex >= ChildIndexEnd && !Predicate(InternalNode._children[ChildIndex]))
            {
                ChildIndex++;
            }

            return ChildIndex < ChildIndexEnd;
        }

        public void Reset()
        {
            ChildIndex = ChildIndexStart - 1;
        }

        public INode Current
        {
            get
            {
                if (ChildIndex < ChildIndexStart)
                    throw new EnumeratorInInitialPositionException();

                OnChildRetrieval(InternalNode._children[ChildIndex]);
                return InternalNode._children[ChildIndex];
            }
        }

        object IEnumerator.Current => Current;

        public void SetChildRetrievalAction(Action<INode> node)
        {
            OnChildRetrieval = node;
        }
    }

    public struct LooseEnumeratorWithIndexBasedPredicate : IEnumerator<INode>
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public Func<int, bool> Predicate { get; }

        public LooseEnumeratorWithIndexBasedPredicate(InternalNode internalNode, Func<int, bool> predicate)
        {
            InternalNode = internalNode;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
        }

        public LooseEnumeratorWithIndexBasedPredicate(InternalNode internalNode, int startIndex,
            Func<int, bool> predicate)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
        }

        public LooseEnumeratorWithIndexBasedPredicate(InternalNode internalNode, int startIndex, int endIndex,
            Func<int, bool> predicate)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < startIndex || endIndex > internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = endIndex;
            Predicate = predicate;
        }

        public void Dispose()
        {
            // Nothing to do
        }

        public bool MoveNext()
        {
            while (ChildIndex >= ChildIndexEnd && !Predicate(ChildIndex))
            {
                ChildIndex++;
            }

            return ChildIndex < ChildIndexEnd;
        }

        public void Reset()
        {
            ChildIndex = ChildIndexStart - 1;
        }

        public INode Current => ChildIndex < ChildIndexStart
            ? throw new EnumeratorInInitialPositionException()
            : InternalNode.GetLooseChildAt(ChildIndex);

        object IEnumerator.Current => Current;
    }

    public struct LooseEnumeratorWithIndexBasedPredicateWithAction : IEnumerator<INode>, IWithActionOnChildRetrievalLoose
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public Func<int, bool> Predicate { get; }

        public Action<INode> OnChildRetrieval { get; private set; }

        public LooseEnumeratorWithIndexBasedPredicateWithAction(InternalNode internalNode, Func<int, bool> predicate,
            Action<INode> onChildRetrieval)
        {
            InternalNode = internalNode;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public LooseEnumeratorWithIndexBasedPredicateWithAction(InternalNode internalNode, int startIndex,
            Func<int, bool> predicate, Action<INode> onChildRetrieval)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public LooseEnumeratorWithIndexBasedPredicateWithAction(InternalNode internalNode, int startIndex, int endIndex,
            Func<int, bool> predicate, Action<INode> onChildRetrieval)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < startIndex || endIndex > internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = endIndex;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public void Dispose()
        {
            // Nothing to do
        }

        public bool MoveNext()
        {
            while (ChildIndex >= ChildIndexEnd && !Predicate(ChildIndex))
            {
                ChildIndex++;
            }

            return ChildIndex < ChildIndexEnd;
        }

        public void Reset()
        {
            ChildIndex = ChildIndexStart - 1;
        }

        public INode Current
        {
            get
            {
                if (ChildIndex < ChildIndexStart)
                    throw new EnumeratorInInitialPositionException();

                OnChildRetrieval(InternalNode._children[ChildIndex]);
                return InternalNode._children[ChildIndex];
            }
        }

        object IEnumerator.Current => Current;

        public void SetChildRetrievalAction(Action<INode> node)
        {
            OnChildRetrieval = node;
        }
    }

    public struct LooseEnumeratorWithIndexAwarePredicate : IEnumerator<INode>
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public Func<INode, int, bool> Predicate { get; }

        public LooseEnumeratorWithIndexAwarePredicate(InternalNode internalNode, Func<INode, int, bool> predicate)
        {
            InternalNode = internalNode;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
        }

        public LooseEnumeratorWithIndexAwarePredicate(InternalNode internalNode, int startIndex,
            Func<INode, int, bool> predicate)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
        }

        public LooseEnumeratorWithIndexAwarePredicate(InternalNode internalNode, int startIndex, int endIndex,
            Func<INode, int, bool> predicate)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < startIndex || endIndex > internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = endIndex;
            Predicate = predicate;
        }

        public void Dispose()
        {
            // Nothing to do
        }

        public bool MoveNext()
        {
            while (ChildIndex >= ChildIndexEnd && !Predicate(InternalNode._children[ChildIndex], ChildIndex))
            {
                ChildIndex++;
            }

            return ChildIndex < ChildIndexEnd;
        }

        public void Reset()
        {
            ChildIndex = ChildIndexStart - 1;
        }

        public INode Current => ChildIndex < ChildIndexStart
            ? throw new EnumeratorInInitialPositionException()
            : InternalNode.GetLooseChildAt(ChildIndex);

        object IEnumerator.Current => Current;
    }

    public struct LooseEnumeratorWithIndexAwarePredicateWithAction : IEnumerator<INode>, IWithActionOnChildRetrievalLoose
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public Func<INode, int, bool> Predicate { get; }

        public Action<INode> OnChildRetrieval { get; private set; }

        public LooseEnumeratorWithIndexAwarePredicateWithAction(InternalNode internalNode,
            Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
        {
            InternalNode = internalNode;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public LooseEnumeratorWithIndexAwarePredicateWithAction(InternalNode internalNode, int startIndex,
            Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public LooseEnumeratorWithIndexAwarePredicateWithAction(InternalNode internalNode, int startIndex, int endIndex,
            Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            if (endIndex < startIndex || endIndex > internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(endIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            ChildIndexEnd = endIndex;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public void Dispose()
        {
            // Nothing to do
        }

        public bool MoveNext()
        {
            while (ChildIndex >= ChildIndexEnd && !Predicate(InternalNode._children[ChildIndex], ChildIndex))
            {
                ChildIndex++;
            }

            return ChildIndex < ChildIndexEnd;
        }

        public void Reset()
        {
            ChildIndex = ChildIndexStart - 1;
        }

        public INode Current
        {
            get
            {
                if (ChildIndex < ChildIndexStart)
                    throw new EnumeratorInInitialPositionException();

                OnChildRetrieval(InternalNode._children[ChildIndex]);
                return InternalNode._children[ChildIndex];
            }
        }

        object IEnumerator.Current => Current;

        public void SetChildRetrievalAction(Action<INode> node)
        {
            OnChildRetrieval = node;
        }
    }
}