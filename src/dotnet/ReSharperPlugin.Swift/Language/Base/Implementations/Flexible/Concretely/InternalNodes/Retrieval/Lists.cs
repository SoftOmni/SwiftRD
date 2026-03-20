using System;
using System.Collections;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public class LooseReadOnlyList : IReadOnlyList<INode>
    {
        private readonly InternalNode _internalNode;

        private LooseEnumerator _looseEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public LooseReadOnlyList(InternalNode internalNode)
        {
            _internalNode = internalNode;
            _looseEnumerator = new LooseEnumerator(internalNode);
        }

        public LooseReadOnlyList(InternalNode internalNode, int startIndex)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _looseEnumerator = new LooseEnumerator(internalNode, startIndex);
        }

        public LooseReadOnlyList(InternalNode internalNode, int startIndex, int endIndex)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _looseEnumerator = new LooseEnumerator(internalNode, startIndex, endIndex);
        }

        ~LooseReadOnlyList()
        {
            _looseEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public INode this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<INode> GetEnumerator()
        {
            return _looseEnumerator;
        }

        public LooseEnumerator GetConcreteEnumerator()
        {
            return _looseEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class LooseReadOnlyListWithAction : IReadOnlyList<INode>, IWithActionOnChildRetrievalLoose
    {
        private readonly InternalNode _internalNode;

        private LooseEnumeratorWithAction _looseEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public Action<INode> OnChildRetrieval => _looseEnumerator.OnChildRetrieval;

        public LooseReadOnlyListWithAction(InternalNode internalNode, Action<INode> onChildRetrieval)
        {
            _internalNode = internalNode;
            _looseEnumerator = new LooseEnumeratorWithAction(internalNode, onChildRetrieval);
        }

        public LooseReadOnlyListWithAction(InternalNode internalNode, int startIndex, Action<INode> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _looseEnumerator = new LooseEnumeratorWithAction(internalNode, startIndex, onChildRetrieval);
        }

        public LooseReadOnlyListWithAction(InternalNode internalNode, int startIndex, int endIndex,
            Action<INode> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _looseEnumerator = new LooseEnumeratorWithAction(internalNode, startIndex, endIndex, onChildRetrieval);
        }

        ~LooseReadOnlyListWithAction()
        {
            _looseEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public INode this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<INode> GetEnumerator()
        {
            return _looseEnumerator;
        }

        public LooseEnumeratorWithAction GetConcreteEnumerator()
        {
            return _looseEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void SetChildRetrievalAction(Action<INode> node)
        {
            _looseEnumerator.SetChildRetrievalAction(node);
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

        public LooseReadOnlyListWithSimplePredicate(InternalNode internalNode, int startIndex,
            Func<INode, bool> predicate)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _looseEnumerator = new LooseEnumeratorWithSimplePredicate(internalNode, startIndex, predicate);
        }

        public LooseReadOnlyListWithSimplePredicate(InternalNode internalNode, int startIndex, int endIndex,
            Func<INode, bool> predicate)
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

        public INode this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<INode> GetEnumerator()
        {
            return _looseEnumerator;
        }

        public LooseEnumeratorWithSimplePredicate GetConcreteEnumerator()
        {
            return _looseEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class LooseReadOnlyListWithSimplePredicateWithAction : IReadOnlyList<INode>, IWithActionOnChildRetrievalLoose
    {
        private readonly InternalNode _internalNode;

        private LooseEnumeratorWithSimplePredicateWithAction _looseEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public Action<INode> OnChildRetrieval => _looseEnumerator.OnChildRetrieval;

        public LooseReadOnlyListWithSimplePredicateWithAction(InternalNode internalNode, Func<INode, bool> predicate,
            Action<INode> onChildRetrieval)
        {
            _internalNode = internalNode;
            _looseEnumerator =
                new LooseEnumeratorWithSimplePredicateWithAction(internalNode, predicate, onChildRetrieval);
        }

        public LooseReadOnlyListWithSimplePredicateWithAction(InternalNode internalNode, int startIndex,
            Func<INode, bool> predicate,
            Action<INode> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _looseEnumerator =
                new LooseEnumeratorWithSimplePredicateWithAction(internalNode, startIndex, predicate, onChildRetrieval);
        }

        public LooseReadOnlyListWithSimplePredicateWithAction(InternalNode internalNode, int startIndex, int endIndex,
            Func<INode, bool> predicate,
            Action<INode> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _looseEnumerator = new LooseEnumeratorWithSimplePredicateWithAction(internalNode, startIndex, endIndex,
                predicate, onChildRetrieval);
        }

        ~LooseReadOnlyListWithSimplePredicateWithAction()
        {
            _looseEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public INode this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<INode> GetEnumerator()
        {
            return _looseEnumerator;
        }

        public LooseEnumeratorWithSimplePredicateWithAction GetConcreteEnumerator()
        {
            return _looseEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void SetChildRetrievalAction(Action<INode> node)
        {
            _looseEnumerator.SetChildRetrievalAction(node);
        }
    }

    public class LooseReadOnlyListWithIndexBasedPredicate : IReadOnlyList<INode>
    {
        private readonly InternalNode _internalNode;

        private LooseEnumeratorWithIndexBasedPredicate _looseEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public LooseReadOnlyListWithIndexBasedPredicate(InternalNode internalNode, Func<int, bool> predicate)
        {
            _internalNode = internalNode;
            _looseEnumerator = new LooseEnumeratorWithIndexBasedPredicate(internalNode, predicate);
        }

        public LooseReadOnlyListWithIndexBasedPredicate(InternalNode internalNode, int startIndex,
            Func<int, bool> predicate)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _looseEnumerator = new LooseEnumeratorWithIndexBasedPredicate(internalNode, startIndex, predicate);
        }

        public LooseReadOnlyListWithIndexBasedPredicate(InternalNode internalNode, int startIndex, int endIndex,
            Func<int, bool> predicate)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _looseEnumerator =
                new LooseEnumeratorWithIndexBasedPredicate(internalNode, startIndex, endIndex, predicate);
        }

        ~LooseReadOnlyListWithIndexBasedPredicate()
        {
            _looseEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public INode this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<INode> GetEnumerator()
        {
            return _looseEnumerator;
        }

        public LooseEnumeratorWithIndexBasedPredicate GetConcreteEnumerator()
        {
            return _looseEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class LooseReadOnlyListWithIndexBasedPredicateWithAction : IReadOnlyList<INode>,
        IWithActionOnChildRetrievalLoose
    {
        private readonly InternalNode _internalNode;

        private LooseEnumeratorWithIndexBasedPredicateWithAction _looseEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public Action<INode> OnChildRetrieval => _looseEnumerator.OnChildRetrieval;

        public LooseReadOnlyListWithIndexBasedPredicateWithAction(InternalNode internalNode, Func<int, bool> predicate,
            Action<INode> onChildRetrieval)
        {
            _internalNode = internalNode;
            _looseEnumerator =
                new LooseEnumeratorWithIndexBasedPredicateWithAction(internalNode, predicate, onChildRetrieval);
        }

        public LooseReadOnlyListWithIndexBasedPredicateWithAction(InternalNode internalNode, int startIndex,
            Func<int, bool> predicate,
            Action<INode> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _looseEnumerator =
                new LooseEnumeratorWithIndexBasedPredicateWithAction(internalNode, startIndex, predicate,
                    onChildRetrieval);
        }

        public LooseReadOnlyListWithIndexBasedPredicateWithAction(InternalNode internalNode, int startIndex,
            int endIndex,
            Func<int, bool> predicate,
            Action<INode> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _looseEnumerator = new LooseEnumeratorWithIndexBasedPredicateWithAction(internalNode, startIndex, endIndex,
                predicate, onChildRetrieval);
        }

        ~LooseReadOnlyListWithIndexBasedPredicateWithAction()
        {
            _looseEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public INode this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<INode> GetEnumerator()
        {
            return _looseEnumerator;
        }

        public LooseEnumeratorWithIndexBasedPredicateWithAction GetConcreteEnumerator()
        {
            return _looseEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void SetChildRetrievalAction(Action<INode> node)
        {
            _looseEnumerator.SetChildRetrievalAction(node);
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

        public LooseReadOnlyListWithIndexAwarePredicate(InternalNode internalNode, int startIndex,
            Func<INode, int, bool> predicate)
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
            _looseEnumerator =
                new LooseEnumeratorWithIndexAwarePredicate(internalNode, startIndex, endIndex, predicate);
        }

        ~LooseReadOnlyListWithIndexAwarePredicate()
        {
            _looseEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public INode this[int index] => _internalNode._children[_startIndex + index];

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

    public class LooseReadOnlyListWithIndexAwarePredicateWithAction : IReadOnlyList<INode>,
        IWithActionOnChildRetrievalLoose
    {
        private readonly InternalNode _internalNode;

        private LooseEnumeratorWithIndexAwarePredicateWithAction _looseEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public Action<INode> OnChildRetrieval => _looseEnumerator.OnChildRetrieval;

        public LooseReadOnlyListWithIndexAwarePredicateWithAction(InternalNode internalNode,
            Func<INode, int, bool> predicate,
            Action<INode> onChildRetrieval)
        {
            _internalNode = internalNode;
            _looseEnumerator =
                new LooseEnumeratorWithIndexAwarePredicateWithAction(internalNode, predicate, onChildRetrieval);
        }

        public LooseReadOnlyListWithIndexAwarePredicateWithAction(InternalNode internalNode, int startIndex,
            Func<INode, int, bool> predicate,
            Action<INode> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _looseEnumerator =
                new LooseEnumeratorWithIndexAwarePredicateWithAction(internalNode, startIndex, predicate,
                    onChildRetrieval);
        }

        public LooseReadOnlyListWithIndexAwarePredicateWithAction(InternalNode internalNode, int startIndex,
            int endIndex,
            Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _looseEnumerator = new LooseEnumeratorWithIndexAwarePredicateWithAction(internalNode, startIndex, endIndex,
                predicate, onChildRetrieval);
        }

        ~LooseReadOnlyListWithIndexAwarePredicateWithAction()
        {
            _looseEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public INode this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<INode> GetEnumerator()
        {
            return _looseEnumerator;
        }

        public LooseEnumeratorWithIndexAwarePredicateWithAction GetConcreteEnumerator()
        {
            return _looseEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void SetChildRetrievalAction(Action<INode> node)
        {
            _looseEnumerator.SetChildRetrievalAction(node);
        }
    }

    public class ConcreteReadOnlyList : IReadOnlyList<Node>
    {
        private readonly InternalNode _internalNode;

        private ConcreteEnumerator _concreteEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public ConcreteReadOnlyList(InternalNode internalNode)
        {
            _internalNode = internalNode;
            _concreteEnumerator = new ConcreteEnumerator(internalNode);
        }

        public ConcreteReadOnlyList(InternalNode internalNode, int startIndex)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _concreteEnumerator = new ConcreteEnumerator(internalNode, startIndex);
        }

        public ConcreteReadOnlyList(InternalNode internalNode, int startIndex, int endIndex)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _concreteEnumerator = new ConcreteEnumerator(internalNode, startIndex, endIndex);
        }

        ~ConcreteReadOnlyList()
        {
            _concreteEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public Node this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<Node> GetEnumerator()
        {
            return _concreteEnumerator;
        }

        public ConcreteEnumerator GetConcreteEnumerator()
        {
            return _concreteEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ConcreteReadOnlyListWithAction : IReadOnlyList<Node>, IWithActionOnChildRetrievalConcrete
    {
        private readonly InternalNode _internalNode;

        private ConcreteEnumeratorWithAction _concreteEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public Action<Node> OnChildRetrieval => _concreteEnumerator.OnChildRetrieval;

        public ConcreteReadOnlyListWithAction(InternalNode internalNode, Action<Node> onChildRetrieval)
        {
            _internalNode = internalNode;
            _concreteEnumerator = new ConcreteEnumeratorWithAction(internalNode, onChildRetrieval);
        }

        public ConcreteReadOnlyListWithAction(InternalNode internalNode, int startIndex, Action<Node> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _concreteEnumerator = new ConcreteEnumeratorWithAction(internalNode, startIndex, onChildRetrieval);
        }

        public ConcreteReadOnlyListWithAction(InternalNode internalNode, int startIndex, int endIndex,
            Action<Node> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _concreteEnumerator =
                new ConcreteEnumeratorWithAction(internalNode, startIndex, endIndex, onChildRetrieval);
        }

        ~ConcreteReadOnlyListWithAction()
        {
            _concreteEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public Node this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<Node> GetEnumerator()
        {
            return _concreteEnumerator;
        }

        public ConcreteEnumeratorWithAction GetConcreteEnumerator()
        {
            return _concreteEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void SetChildRetrievalAction(Action<Node> node)
        {
            _concreteEnumerator.SetChildRetrievalAction(node);
        }
    }

    public class ConcreteReadOnlyListWithSimplePredicate : IReadOnlyList<Node>
    {
        private readonly InternalNode _internalNode;

        private ConcreteEnumeratorWithSimplePredicate _concreteEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public ConcreteReadOnlyListWithSimplePredicate(InternalNode internalNode, Func<Node, bool> predicate)
        {
            _internalNode = internalNode;
            _concreteEnumerator = new ConcreteEnumeratorWithSimplePredicate(internalNode, predicate);
        }

        public ConcreteReadOnlyListWithSimplePredicate(InternalNode internalNode, int startIndex,
            Func<Node, bool> predicate)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _concreteEnumerator = new ConcreteEnumeratorWithSimplePredicate(internalNode, startIndex, predicate);
        }

        public ConcreteReadOnlyListWithSimplePredicate(InternalNode internalNode, int startIndex, int endIndex,
            Func<Node, bool> predicate)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _concreteEnumerator =
                new ConcreteEnumeratorWithSimplePredicate(internalNode, startIndex, endIndex, predicate);
        }

        ~ConcreteReadOnlyListWithSimplePredicate()
        {
            _concreteEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public Node this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<Node> GetEnumerator()
        {
            return _concreteEnumerator;
        }

        public ConcreteEnumeratorWithSimplePredicate GetConcreteEnumerator()
        {
            return _concreteEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ConcreteReadOnlyListWithSimplePredicateWithAction : IReadOnlyList<Node>,
        IWithActionOnChildRetrievalConcrete
    {
        private readonly InternalNode _internalNode;

        private ConcreteEnumeratorWithSimplePredicateWithAction _concreteEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public Action<Node> OnChildRetrieval => _concreteEnumerator.OnChildRetrieval;

        public ConcreteReadOnlyListWithSimplePredicateWithAction(InternalNode internalNode, Func<Node, bool> predicate,
            Action<Node> onChildRetrieval)
        {
            _internalNode = internalNode;
            _concreteEnumerator =
                new ConcreteEnumeratorWithSimplePredicateWithAction(internalNode, predicate, onChildRetrieval);
        }

        public ConcreteReadOnlyListWithSimplePredicateWithAction(InternalNode internalNode, int startIndex,
            Func<Node, bool> predicate,
            Action<Node> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _concreteEnumerator =
                new ConcreteEnumeratorWithSimplePredicateWithAction(internalNode, startIndex, predicate,
                    onChildRetrieval);
        }

        public ConcreteReadOnlyListWithSimplePredicateWithAction(InternalNode internalNode, int startIndex,
            int endIndex, Func<Node, bool> predicate,
            Action<Node> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _concreteEnumerator = new ConcreteEnumeratorWithSimplePredicateWithAction(internalNode, startIndex,
                endIndex, predicate, onChildRetrieval);
        }

        ~ConcreteReadOnlyListWithSimplePredicateWithAction()
        {
            _concreteEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public Node this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<Node> GetEnumerator()
        {
            return _concreteEnumerator;
        }

        public ConcreteEnumeratorWithSimplePredicateWithAction GetConcreteEnumerator()
        {
            return _concreteEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void SetChildRetrievalAction(Action<Node> node)
        {
            _concreteEnumerator.SetChildRetrievalAction(node);
        }
    }

    public class ConcreteReadOnlyListWithIndexBasedPredicate : IReadOnlyList<Node>
    {
        private readonly InternalNode _internalNode;

        private ConcreteEnumeratorWithIndexBasedPredicate _concreteEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public ConcreteReadOnlyListWithIndexBasedPredicate(InternalNode internalNode, Func<int, bool> predicate)
        {
            _internalNode = internalNode;
            _concreteEnumerator = new ConcreteEnumeratorWithIndexBasedPredicate(internalNode, predicate);
        }

        public ConcreteReadOnlyListWithIndexBasedPredicate(InternalNode internalNode, int startIndex,
            Func<int, bool> predicate)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _concreteEnumerator = new ConcreteEnumeratorWithIndexBasedPredicate(internalNode, startIndex, predicate);
        }

        public ConcreteReadOnlyListWithIndexBasedPredicate(InternalNode internalNode, int startIndex, int endIndex,
            Func<int, bool> predicate)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _concreteEnumerator =
                new ConcreteEnumeratorWithIndexBasedPredicate(internalNode, startIndex, endIndex, predicate);
        }

        ~ConcreteReadOnlyListWithIndexBasedPredicate()
        {
            _concreteEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public Node this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<Node> GetEnumerator()
        {
            return _concreteEnumerator;
        }

        public ConcreteEnumeratorWithIndexBasedPredicate GetConcreteEnumerator()
        {
            return _concreteEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ConcreteReadOnlyListWithIndexBasedPredicateWithAction : IReadOnlyList<Node>,
        IWithActionOnChildRetrievalConcrete
    {
        private readonly InternalNode _internalNode;

        private ConcreteEnumeratorWithIndexBasedPredicateWithAction _concreteEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public Action<Node> OnChildRetrieval => _concreteEnumerator.OnChildRetrieval;

        public ConcreteReadOnlyListWithIndexBasedPredicateWithAction(InternalNode internalNode, Func<int, bool> predicate,
            Action<Node> onChildRetrieval)
        {
            _internalNode = internalNode;
            _concreteEnumerator =
                new ConcreteEnumeratorWithIndexBasedPredicateWithAction(internalNode, predicate, onChildRetrieval);
        }

        public ConcreteReadOnlyListWithIndexBasedPredicateWithAction(InternalNode internalNode, int startIndex,
            Func<int, bool> predicate,
            Action<Node> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _concreteEnumerator =
                new ConcreteEnumeratorWithIndexBasedPredicateWithAction(internalNode, startIndex, predicate,
                    onChildRetrieval);
        }

        public ConcreteReadOnlyListWithIndexBasedPredicateWithAction(InternalNode internalNode, int startIndex,
            int endIndex, Func<int, bool> predicate,
            Action<Node> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _concreteEnumerator = new ConcreteEnumeratorWithIndexBasedPredicateWithAction(internalNode, startIndex,
                endIndex, predicate, onChildRetrieval);
        }

        ~ConcreteReadOnlyListWithIndexBasedPredicateWithAction()
        {
            _concreteEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public Node this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<Node> GetEnumerator()
        {
            return _concreteEnumerator;
        }

        public ConcreteEnumeratorWithIndexBasedPredicateWithAction GetConcreteEnumerator()
        {
            return _concreteEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void SetChildRetrievalAction(Action<Node> node)
        {
            _concreteEnumerator.SetChildRetrievalAction(node);
        }
    }

    public class ConcreteReadOnlyListWithIndexAwarePredicate : IReadOnlyList<Node>
    {
        private readonly InternalNode _internalNode;

        private ConcreteEnumeratorWithIndexAwarePredicate _concreteEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public ConcreteReadOnlyListWithIndexAwarePredicate(InternalNode internalNode, Func<Node, int, bool> predicate)
        {
            _internalNode = internalNode;
            _concreteEnumerator = new ConcreteEnumeratorWithIndexAwarePredicate(internalNode, predicate);
        }

        public ConcreteReadOnlyListWithIndexAwarePredicate(InternalNode internalNode, int startIndex,
            Func<Node, int, bool> predicate)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _concreteEnumerator = new ConcreteEnumeratorWithIndexAwarePredicate(internalNode, predicate);
        }

        public ConcreteReadOnlyListWithIndexAwarePredicate(InternalNode internalNode, int startIndex, int endIndex,
            Func<Node, int, bool> predicate)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _concreteEnumerator = new ConcreteEnumeratorWithIndexAwarePredicate(internalNode, startIndex, predicate);
        }

        ~ConcreteReadOnlyListWithIndexAwarePredicate()
        {
            _concreteEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public Node this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<Node> GetEnumerator()
        {
            return _concreteEnumerator;
        }

        public ConcreteEnumeratorWithIndexAwarePredicate GetConcreteEnumerator()
        {
            return _concreteEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }

    public class ConcreteReadOnlyListWithIndexAwarePredicateWithAction : IReadOnlyList<Node>,
        IWithActionOnChildRetrievalConcrete
    {
        private readonly InternalNode _internalNode;

        private ConcreteEnumeratorWithIndexAwarePredicateWithAction _concreteEnumerator;

        private readonly int _startIndex;

        // ReSharper disable once ReplaceWithFieldKeyword
        private readonly int _endIndex;

        public Action<Node> OnChildRetrieval => _concreteEnumerator.OnChildRetrieval;

        public ConcreteReadOnlyListWithIndexAwarePredicateWithAction(InternalNode internalNode,
            Func<Node, int, bool> predicate,
            Action<Node> onChildRetrieval)
        {
            _internalNode = internalNode;
            _concreteEnumerator =
                new ConcreteEnumeratorWithIndexAwarePredicateWithAction(internalNode, predicate, onChildRetrieval);
        }

        public ConcreteReadOnlyListWithIndexAwarePredicateWithAction(InternalNode internalNode, int startIndex,
            Func<Node, int, bool> predicate,
            Action<Node> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _concreteEnumerator =
                new ConcreteEnumeratorWithIndexAwarePredicateWithAction(internalNode, startIndex, predicate,
                    onChildRetrieval);
        }

        public ConcreteReadOnlyListWithIndexAwarePredicateWithAction(InternalNode internalNode, int startIndex,
            int endIndex, Func<Node, int, bool> predicate,
            Action<Node> onChildRetrieval)
        {
            _internalNode = internalNode;
            _startIndex = startIndex;
            _endIndex = endIndex;
            _concreteEnumerator =
                new ConcreteEnumeratorWithIndexAwarePredicateWithAction(internalNode, startIndex, endIndex, predicate,
                    onChildRetrieval);
        }

        ~ConcreteReadOnlyListWithIndexAwarePredicateWithAction()
        {
            _concreteEnumerator.Dispose();
        }

        public int Count => _endIndex - _startIndex;

        public Node this[int index] => _internalNode._children[_startIndex + index];

        public IEnumerator<Node> GetEnumerator()
        {
            return _concreteEnumerator;
        }

        public ConcreteEnumeratorWithIndexAwarePredicateWithAction GetConcreteEnumerator()
        {
            return _concreteEnumerator;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void SetChildRetrievalAction(Action<Node> node)
        {
            _concreteEnumerator.SetChildRetrievalAction(node);
        }
    }

    public class LooseListWithAction(List<INode> nodes, Action<INode> onChildRetrieval)
        : IList<INode>, IWithActionOnChildRetrievalLoose
    {
        public Action<INode> OnChildRetrieval { get; private set; } = onChildRetrieval;

        public void Add(INode item)
        {
            nodes.Add(item);
        }

        public void Clear()
        {
            nodes.Clear();
        }

        public bool Contains(INode item)
        {
            return nodes.Contains(item);
        }

        public void CopyTo(INode[] array, int arrayIndex)
        {
            nodes.CopyTo(array, arrayIndex);
        }

        public bool Remove(INode item)
        {
            return nodes.Remove(item);
        }

        public int Count => nodes.Count;

        public bool IsReadOnly => false;

        public int IndexOf(INode item)
        {
            return nodes.IndexOf(item);
        }

        public void Insert(int index, INode item)
        {
            nodes.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            nodes.RemoveAt(index);
        }

        public INode this[int index]
        {
            get
            {
                OnChildRetrieval(nodes[index]);
                return nodes[index];
            }

            set => nodes[index] = value;
        }

        public IEnumerator<INode> GetEnumerator()
        {
            return nodes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void SetChildRetrievalAction(Action<INode> node)
        {
            OnChildRetrieval = node;
        }
    }

    public class ConcreteListWithAction(List<Node> nodes, Action<Node> onChildRetrieval)
        : IList<Node>, IWithActionOnChildRetrievalConcrete
    {
        public Action<Node> OnChildRetrieval { get; private set; } = onChildRetrieval;

        public void Add(Node item)
        {
            nodes.Add(item);
        }

        public void Clear()
        {
            nodes.Clear();
        }

        public bool Contains(Node item)
        {
            return nodes.Contains(item);
        }

        public void CopyTo(Node[] array, int arrayIndex)
        {
            nodes.CopyTo(array, arrayIndex);
        }

        public bool Remove(Node item)
        {
            return nodes.Remove(item);
        }

        public int Count => nodes.Count;

        public bool IsReadOnly => false;

        public int IndexOf(Node item)
        {
            return nodes.IndexOf(item);
        }

        public void Insert(int index, Node item)
        {
            nodes.Insert(index, item);
        }

        public void RemoveAt(int index)
        {
            nodes.RemoveAt(index);
        }

        public Node this[int index]
        {
            get
            {
                OnChildRetrieval(nodes[index]);
                return nodes[index];
            }

            set => nodes[index] = value;
        }

        public IEnumerator<Node> GetEnumerator()
        {
            return nodes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void SetChildRetrievalAction(Action<Node> node)
        {
            OnChildRetrieval = node;
        }
    }

    public class ListWithLooseNodesWithAction : List<INode>, IWithActionOnChildRetrievalLoose
    {
        public Action<INode> OnChildRetrieval { get; private set; }

        public ListWithLooseNodesWithAction(Action<INode> onChildRetrieval)
        {
            OnChildRetrieval = onChildRetrieval;
        }

        public ListWithLooseNodesWithAction(IEnumerable<INode> nodes, Action<INode> onChildRetrieval)
            : base(nodes)
        {
            OnChildRetrieval = onChildRetrieval;
        }

        public ListWithLooseNodesWithAction(List<INode> nodes, Action<INode> onChildRetrieval)
            : base(nodes)
        {
            OnChildRetrieval = onChildRetrieval;
        }

        public ListWithLooseNodesWithAction(int capacity, Action<INode> onChildRetrieval)
            : base(capacity)
        {
            OnChildRetrieval = onChildRetrieval;
        }

        public new INode this[int index]
        {
            get
            {
                OnChildRetrieval(base[index]);
                return base[index];
            }
            set => base[index] = value;
        }

        public void SetChildRetrievalAction(Action<INode> node)
        {
            OnChildRetrieval = node;
        }
    }

    public class ListWithConcreteNodesWithAction : List<Node>, IWithActionOnChildRetrievalConcrete
    {
        public Action<Node> OnChildRetrieval { get; private set; }

        public ListWithConcreteNodesWithAction(Action<Node> onChildRetrieval)
        {
            OnChildRetrieval = onChildRetrieval;
        }

        public ListWithConcreteNodesWithAction(IEnumerable<Node> nodes, Action<Node> onChildRetrieval)
            : base(nodes)
        {
            OnChildRetrieval = onChildRetrieval;
        }

        public ListWithConcreteNodesWithAction(List<Node> nodes, Action<Node> onChildRetrieval)
            : base(nodes)
        {
            OnChildRetrieval = onChildRetrieval;
        }

        public ListWithConcreteNodesWithAction(int capacity, Action<Node> onChildRetrieval)
            : base(capacity)
        {
            OnChildRetrieval = onChildRetrieval;
        }

        public new Node this[int index]
        {
            get
            {
                OnChildRetrieval(base[index]);
                return base[index];
            }
            set => base[index] = value;
        }

        public void SetChildRetrievalAction(Action<Node> node)
        {
            OnChildRetrieval = node;
        }
    }
}