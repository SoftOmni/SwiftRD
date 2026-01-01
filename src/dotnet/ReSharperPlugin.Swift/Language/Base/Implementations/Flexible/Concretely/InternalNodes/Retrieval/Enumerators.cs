using System;
using System.Collections;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;
using ReSharperPlugin.Swift.Technology.Exceptions;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.InternalNodes;

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

        public Node CurrentConcrete => ChildIndex < ChildIndexStart
            ? throw new EnumeratorInInitialPositionException()
            : InternalNode.GetConcreteChildAt(ChildIndex);

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

        public Node CurrentConcrete
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
            : InternalNode.GetConcreteChildAt(ChildIndex);

        public Node CurrentConcrete => ChildIndex < ChildIndexStart
            ? throw new EnumeratorInInitialPositionException()
            : InternalNode.GetConcreteChildAt(ChildIndex);

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

        public Node CurrentConcrete
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
            : InternalNode.GetConcreteChildAt(ChildIndex);

        public Node CurrentConcrete => ChildIndex < ChildIndexStart
            ? throw new EnumeratorInInitialPositionException()
            : InternalNode.GetConcreteChildAt(ChildIndex);

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

        public Node CurrentConcrete
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
            : InternalNode.GetConcreteChildAt(ChildIndex);

        public Node CurrentConcrete => ChildIndex < ChildIndexStart
            ? throw new EnumeratorInInitialPositionException()
            : InternalNode.GetConcreteChildAt(ChildIndex);

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

        public Node CurrentConcrete
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


    public struct ConcreteEnumerator : IEnumerator<Node>
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public ConcreteEnumerator(InternalNode internalNode)
        {
            InternalNode = internalNode;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
        }

        public ConcreteEnumerator(InternalNode internalNode, int startIndex)
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

        public ConcreteEnumerator(InternalNode internalNode, int startIndex, int endIndex)
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

        public Node Current => ChildIndex < ChildIndexStart
            ? throw new EnumeratorInInitialPositionException()
            : InternalNode.GetConcreteChildAt(ChildIndex);

        object IEnumerator.Current => Current;
    }

    public struct ConcreteEnumeratorWithAction : IEnumerator<Node>, IWithActionOnChildRetrievalConcrete
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public Action<Node> OnChildRetrieval { get; private set; }

        public ConcreteEnumeratorWithAction(InternalNode internalNode, Action<Node> onChildRetrieval)
        {
            InternalNode = internalNode;
            OnChildRetrieval = onChildRetrieval;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
        }

        public ConcreteEnumeratorWithAction(InternalNode internalNode, int startIndex, Action<Node> onChildRetrieval)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildIndexStart = startIndex;
            OnChildRetrieval = onChildRetrieval;
            ChildIndexEnd = internalNode.NumberOfChildren;
        }

        public ConcreteEnumeratorWithAction(InternalNode internalNode, int startIndex, int endIndex,
            Action<Node> onChildRetrieval)
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

        public Node Current
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

        public void SetChildRetrievalAction(Action<Node> node)
        {
            OnChildRetrieval = node;
        }
    }

    public struct ConcreteEnumeratorWithSimplePredicate : IEnumerator<Node>
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public Func<Node, bool> Predicate { get; }

        public ConcreteEnumeratorWithSimplePredicate(InternalNode internalNode, Func<Node, bool> predicate)
        {
            InternalNode = internalNode;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
        }

        public ConcreteEnumeratorWithSimplePredicate(InternalNode internalNode, int startIndex,
            Func<Node, bool> predicate)
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

        public ConcreteEnumeratorWithSimplePredicate(InternalNode internalNode, int startIndex, int endIndex,
            Func<Node, bool> predicate)
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

        public Node Current => ChildIndex < ChildIndexStart
            ? throw new EnumeratorInInitialPositionException()
            : InternalNode.GetConcreteChildAt(ChildIndex);

        object IEnumerator.Current => Current;
    }

    public struct ConcreteEnumeratorWithSimplePredicateWithAction : IEnumerator<Node>, IWithActionOnChildRetrievalConcrete
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public Func<Node, bool> Predicate { get; }

        public Action<Node> OnChildRetrieval { get; private set; }

        public ConcreteEnumeratorWithSimplePredicateWithAction(InternalNode internalNode, Func<Node, bool> predicate,
            Action<Node> onChildRetrieval)
        {
            InternalNode = internalNode;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public ConcreteEnumeratorWithSimplePredicateWithAction(InternalNode internalNode, int startIndex,
            Func<Node, bool> predicate, Action<Node> onChildRetrieval)
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

        public ConcreteEnumeratorWithSimplePredicateWithAction(InternalNode internalNode, int startIndex, int endIndex,
            Func<Node, bool> predicate, Action<Node> onChildRetrieval)
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

        public Node Current
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

        public void SetChildRetrievalAction(Action<Node> node)
        {
            OnChildRetrieval = node;
        }
    }

    public struct ConcreteEnumeratorWithIndexBasedPredicate : IEnumerator<Node>
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public Func<int, bool> Predicate { get; }

        public ConcreteEnumeratorWithIndexBasedPredicate(InternalNode internalNode, Func<int, bool> predicate)
        {
            InternalNode = internalNode;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
        }

        public ConcreteEnumeratorWithIndexBasedPredicate(InternalNode internalNode, int startIndex,
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

        public ConcreteEnumeratorWithIndexBasedPredicate(InternalNode internalNode, int startIndex, int endIndex,
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

        public Node Current => ChildIndex < ChildIndexStart
            ? throw new EnumeratorInInitialPositionException()
            : InternalNode.GetConcreteChildAt(ChildIndex);

        object IEnumerator.Current => Current;
    }

    public struct ConcreteEnumeratorWithIndexBasedPredicateWithAction : IEnumerator<Node>, IWithActionOnChildRetrievalConcrete
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildIndexStart { get; }

        public int ChildIndexEnd { get; }

        public Func<int, bool> Predicate { get; }

        public Action<Node> OnChildRetrieval { get; private set; }

        public ConcreteEnumeratorWithIndexBasedPredicateWithAction(InternalNode internalNode, Func<int, bool> predicate,
            Action<Node> onChildRetrieval)
        {
            InternalNode = internalNode;
            ChildIndex = -1;
            ChildIndexStart = 0;
            ChildIndexEnd = internalNode.NumberOfChildren;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public ConcreteEnumeratorWithIndexBasedPredicateWithAction(InternalNode internalNode, int startIndex,
            Func<int, bool> predicate, Action<Node> onChildRetrieval)
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

        public ConcreteEnumeratorWithIndexBasedPredicateWithAction(InternalNode internalNode, int startIndex, int endIndex,
            Func<int, bool> predicate, Action<Node> onChildRetrieval)
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

        public Node Current
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

        public void SetChildRetrievalAction(Action<Node> node)
        {
            OnChildRetrieval = node;
        }
    }

    public struct ConcreteEnumeratorWithIndexAwarePredicate : IEnumerator<Node>
    {
        public InternalNode InternalNode { get; }

        public int Index { get; private set; }

        public int StartIndex { get; }

        public int EndIndex { get; }

        public Func<Node, int, bool> Predicate { get; }


        public ConcreteEnumeratorWithIndexAwarePredicate(InternalNode internalNode,
            Func<Node, int, bool> predicate)
        {
            InternalNode = internalNode;
            Index = 0 - 1;
            EndIndex = internalNode.NumberOfChildren;
            Predicate = predicate;
        }

        public ConcreteEnumeratorWithIndexAwarePredicate(InternalNode internalNode, int startIndex,
            Func<Node, int, bool> predicate)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            InternalNode = internalNode;
            Index = startIndex - 1;
            StartIndex = startIndex;
            EndIndex = internalNode.NumberOfChildren;
            Predicate = predicate;
        }

        public ConcreteEnumeratorWithIndexAwarePredicate(InternalNode internalNode, int startIndex, int endIndex,
            Func<Node, int, bool> predicate)
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
            Index = startIndex - 1;
            StartIndex = startIndex;
            EndIndex = endIndex;
            Predicate = predicate;
        }

        public void Dispose()
        {
            // Nothing to do
        }

        public bool MoveNext()
        {
            while (Index >= EndIndex && !Predicate(InternalNode._children[Index], Index))
            {
                Index++;
            }

            return Index < EndIndex;
        }

        public void Reset()
        {
            Index = StartIndex - 1;
        }

        public Node Current => Index < StartIndex
            ? throw new EnumeratorInInitialPositionException()
            : InternalNode.GetConcreteChildAt(Index);

        object IEnumerator.Current => Current;
    }

    public struct ConcreteEnumeratorWithIndexAwarePredicateWithAction : IEnumerator<Node>, IWithActionOnChildRetrievalConcrete
    {
        public InternalNode InternalNode { get; }

        public int ChildIndex { get; private set; }

        public int ChildStartIndex { get; }

        public int ChildEndIndex { get; }

        public Func<Node, int, bool> Predicate { get; }

        public Action<Node> OnChildRetrieval { get; private set; }

        public ConcreteEnumeratorWithIndexAwarePredicateWithAction(InternalNode internalNode,
            Func<Node, int, bool> predicate, Action<Node> onChildRetrieval)
        {
            InternalNode = internalNode;
            ChildIndex = 0 - 1;
            ChildEndIndex = internalNode.NumberOfChildren;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public ConcreteEnumeratorWithIndexAwarePredicateWithAction(InternalNode internalNode, int startIndex,
            Func<Node, int, bool> predicate, Action<Node> onChildRetrieval)
        {
            if (startIndex < 0 || startIndex >= internalNode.NumberOfChildren)
            {
                throw new ArgumentOutOfRangeException(nameof(startIndex));
            }

            InternalNode = internalNode;
            ChildIndex = startIndex - 1;
            ChildStartIndex = startIndex;
            ChildEndIndex = internalNode.NumberOfChildren;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public ConcreteEnumeratorWithIndexAwarePredicateWithAction(InternalNode internalNode, int startIndex,
            int endIndex,
            Func<Node, int, bool> predicate, Action<Node> onChildRetrieval)
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
            ChildStartIndex = startIndex;
            ChildEndIndex = endIndex;
            Predicate = predicate;
            OnChildRetrieval = onChildRetrieval;
        }

        public void Dispose()
        {
            // Nothing to do
        }

        public bool MoveNext()
        {
            while (ChildIndex >= ChildEndIndex && !Predicate(InternalNode._children[ChildIndex], ChildIndex))
            {
                ChildIndex++;
            }

            return ChildIndex < ChildEndIndex;
        }

        public void Reset()
        {
            ChildIndex = ChildStartIndex - 1;
        }

        public Node Current
        {
            get
            {
                if (ChildIndex < ChildStartIndex)
                    throw new EnumeratorInInitialPositionException();

                OnChildRetrieval(InternalNode._children[ChildIndex]);
                return InternalNode._children[ChildIndex];
            }
        }

        object IEnumerator.Current => Current;

        public void SetChildRetrievalAction(Action<Node> node)
        {
            OnChildRetrieval = node;
        }
    }
}