using System;
using System.Collections;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.Internal;

public partial class SwiftInternalNode
{
    

    public class LooseReadOnlyList : IReadOnlyList<INode>
    {
        private readonly InternalNode _internalNode;

        private InternalNodes.InternalNode.LooseEnumerator _looseEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public LooseReadOnlyList(InternalNode internalNode)
        {
            _internalNode = internalNode;
            _looseEnumerator = new InternalNodes.InternalNode.LooseEnumerator(internalNode);
        }

        public LooseReadOnlyList(InternalNode internalNode, int startIndex)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _looseEnumerator = new InternalNodes.InternalNode.LooseEnumerator(internalNode, startIndex);
        }

        public LooseReadOnlyList(InternalNode internalNode, int startIndex, int endIndex)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _looseEnumerator = new InternalNodes.InternalNode.LooseEnumerator(internalNode, startIndex, endIndex);
        }

        ~LooseReadOnlyList()
        {
            _looseEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public INode this[int index] => _internalNode.Children[_startIndex + index];

        public IEnumerator<INode> GetEnumerator()
        {
            return _looseEnumerator;
        }

        public InternalNodes.InternalNode.LooseEnumerator GetConcreteEnumerator()
        {
            return _looseEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class LooseReadOnlyListWithSimplePredicate : IReadOnlyList<INode>
    {
        private readonly InternalNode _internalNode;

        private LooseEnumeratorWithSimplePredicate _looseEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public LooseReadOnlyListWithSimplePredicate(InternalNode internalNode, Func<INode, bool> predicate)
        {
            _internalNode = internalNode;
            _looseEnumerator = new LooseEnumeratorWithSimplePredicate(internalNode, predicate);
        }

        public LooseReadOnlyListWithSimplePredicate(InternalNode internalNode, int startIndex, Func<INode, bool> predicate)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _looseEnumerator = new LooseEnumeratorWithSimplePredicate(internalNode, startIndex, predicate);
        }

        public LooseReadOnlyListWithSimplePredicate(InternalNode internalNode, int startIndex, int endIndex, Func<INode, bool> predicate)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _looseEnumerator = new LooseEnumeratorWithSimplePredicate(internalNode, startIndex, endIndex, predicate);
        }

        ~LooseReadOnlyListWithSimplePredicate()
        {
            _looseEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public INode this[int index] => _internalNode.Children[_startIndex + index];

        public IEnumerator<INode> GetEnumerator()
        {
            return _looseEnumerator;
        }

        public InternalNodes.InternalNode.LooseEnumeratorWithSimplePredicate GetConcreteEnumerator()
        {
            return _looseEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class LooseReadOnlyListWithIndexAwarePredicate : IReadOnlyList<INode>
    {
        private readonly InternalNode _internalNode;

        private LooseEnumeratorWithIndexAwarePredicate _looseEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public LooseReadOnlyListWithIndexAwarePredicate(InternalNode internalNode, Func<INode, int, bool> predicate)
        {
            _internalNode = internalNode;
            _looseEnumerator = new LooseEnumeratorWithIndexAwarePredicate(internalNode, predicate);
        }

        public LooseReadOnlyListWithIndexAwarePredicate(InternalNode internalNode, int startIndex, Func<INode, int, bool> predicate)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _looseEnumerator = new LooseEnumeratorWithIndexAwarePredicate(internalNode, startIndex, predicate);
        }

        public LooseReadOnlyListWithIndexAwarePredicate(InternalNode internalNode, int startIndex, int endIndex, 
            Func<INode, int, bool> predicate)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _looseEnumerator = new LooseEnumeratorWithIndexAwarePredicate(internalNode, startIndex, endIndex, predicate);
        }

        ~LooseReadOnlyListWithIndexAwarePredicate()
        {
            _looseEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public INode this[int index] => _internalNode.Children[_startIndex + index];

        public IEnumerator<INode> GetEnumerator()
        {
            return _looseEnumerator;
        }

        public LooseEnumeratorWithIndexAwarePredicate GetConcreteEnumerator()
        {
            return _looseEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}