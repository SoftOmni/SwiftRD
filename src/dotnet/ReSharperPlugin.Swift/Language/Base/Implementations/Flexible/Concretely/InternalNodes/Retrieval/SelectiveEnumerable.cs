using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.InternalNodes;

public partial class InternalNode
{
    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, bool> predicate)
        => GetSelectiveLooseNodesAsEnumerable(predicate);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsEnumerable(predicate, onChildRetrieval);
    
    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<int, bool> predicate)
        => GetSelectiveLooseNodesAsEnumerable(predicate);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<int, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsEnumerable(predicate, onChildRetrieval);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, int, bool> predicate)
        => GetSelectiveLooseNodesAsEnumerable(predicate);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsEnumerable(predicate, onChildRetrieval);

    public LooseReadOnlyListWithSimplePredicate GetSelectiveLooseNodesAsEnumerable(Func<INode, bool> predicate)
    {
        return new LooseReadOnlyListWithSimplePredicate(this, predicate);
    }

    public LooseReadOnlyListWithSimplePredicateWithAction GetSelectiveLooseNodesAsEnumerable(Func<INode, bool> predicate, Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithSimplePredicateWithAction(this, predicate, onChildRetrieval);
    }

    public LooseReadOnlyListWithIndexBasedPredicate GetSelectiveLooseNodesAsEnumerable(Func<int, bool> predicate)
    {
        return new LooseReadOnlyListWithIndexBasedPredicate(this, predicate);
    }

    public LooseReadOnlyListWithIndexBasedPredicateWithAction GetSelectiveLooseNodesAsEnumerable(Func<int, bool> predicate, Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithIndexBasedPredicateWithAction(this, predicate, onChildRetrieval);
    }

    public LooseReadOnlyListWithIndexAwarePredicate GetSelectiveLooseNodesAsEnumerable(Func<INode, int, bool> predicate)
    {
        return new LooseReadOnlyListWithIndexAwarePredicate(this, predicate);
    }

    public LooseReadOnlyListWithIndexAwarePredicateWithAction GetSelectiveLooseNodesAsEnumerable(Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithIndexAwarePredicateWithAction(this, predicate, onChildRetrieval);
    }

    public ConcreteReadOnlyListWithSimplePredicate GetSelectiveConcreteNodesAsEnumerable(Func<Node, bool> predicate)
    {
        return new ConcreteReadOnlyListWithSimplePredicate(this, predicate);
    }

    public ConcreteReadOnlyListWithSimplePredicateWithAction GetSelectiveConcreteNodesAsEnumerable(Func<Node, bool> predicate, Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithSimplePredicateWithAction(this, predicate, onChildRetrieval);
    }

    public ConcreteReadOnlyListWithIndexBasedPredicate GetSelectiveConcreteNodesAsEnumerable(Func<int, bool> predicate)
    {
        return new ConcreteReadOnlyListWithIndexBasedPredicate(this, predicate);
    }

    public ConcreteReadOnlyListWithIndexBasedPredicateWithAction GetSelectiveConcreteNodesAsEnumerable(Func<int, bool> predicate, Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithIndexBasedPredicateWithAction(this, predicate, onChildRetrieval);
    }

    public ConcreteReadOnlyListWithIndexAwarePredicate GetSelectiveConcreteNodesAsEnumerable(Func<Node, int, bool> predicate)
    {
        return new ConcreteReadOnlyListWithIndexAwarePredicate(this, predicate);
    }

    public ConcreteReadOnlyListWithIndexAwarePredicateWithAction GetSelectiveConcreteNodesAsEnumerable(Func<Node, int, bool> predicate, Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithIndexAwarePredicateWithAction(this, predicate, onChildRetrieval);
    }

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesAsEnumerable(predicate, startIndex);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsEnumerable(predicate, startIndex, onChildRetrieval);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<int, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesAsEnumerable(predicate, startIndex);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsEnumerable(predicate, startIndex, onChildRetrieval);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, int, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesAsEnumerable(predicate, startIndex);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsEnumerable(predicate, startIndex, onChildRetrieval);

    public LooseReadOnlyListWithSimplePredicate GetSelectiveLooseNodesAsEnumerable(Func<INode, bool> predicate, int startIndex)
    {
        return new LooseReadOnlyListWithSimplePredicate(this, startIndex, predicate);
    }

    public LooseReadOnlyListWithSimplePredicateWithAction GetSelectiveLooseNodesAsEnumerable(Func<INode, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithSimplePredicateWithAction(this, startIndex, predicate, onChildRetrieval);
    }

    public LooseReadOnlyListWithIndexBasedPredicate GetSelectiveLooseNodesAsEnumerable(Func<int, bool> predicate, int startIndex)
    {
        return new LooseReadOnlyListWithIndexBasedPredicate(this, startIndex, predicate);
    }

    public LooseReadOnlyListWithIndexBasedPredicateWithAction GetSelectiveLooseNodesAsEnumerable(Func<int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithIndexBasedPredicateWithAction(this, startIndex, predicate, onChildRetrieval);
    }

    public LooseReadOnlyListWithIndexAwarePredicate GetSelectiveLooseNodesAsEnumerable(Func<INode, int, bool> predicate, int startIndex)
    {
        return new LooseReadOnlyListWithIndexAwarePredicate(this, startIndex, predicate);
    }

    public LooseReadOnlyListWithIndexAwarePredicateWithAction GetSelectiveLooseNodesAsEnumerable(Func<INode, int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithIndexAwarePredicateWithAction(this, startIndex, predicate, onChildRetrieval);
    }

    public ConcreteReadOnlyListWithSimplePredicate GetSelectiveConcreteNodesAsEnumerable(Func<Node, bool> predicate, int startIndex)
    {
        return new ConcreteReadOnlyListWithSimplePredicate(this, startIndex, predicate);
    }

    public ConcreteReadOnlyListWithSimplePredicateWithAction GetSelectiveConcreteNodesAsEnumerable(Func<Node, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithSimplePredicateWithAction(this, startIndex, predicate, onChildRetrieval);
    }

    public ConcreteReadOnlyListWithIndexBasedPredicate GetSelectiveConcreteNodesAsEnumerable(Func<int, bool> predicate, int startIndex)
    {
        return new ConcreteReadOnlyListWithIndexBasedPredicate(this, startIndex, predicate);
    }

    public ConcreteReadOnlyListWithIndexBasedPredicateWithAction GetSelectiveConcreteNodesAsEnumerable(Func<int, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithIndexBasedPredicateWithAction(this, startIndex, predicate, onChildRetrieval);
    }

    public ConcreteReadOnlyListWithIndexAwarePredicate GetSelectiveConcreteNodesAsEnumerable(Func<Node, int, bool> predicate, int startIndex)
    {
        return new ConcreteReadOnlyListWithIndexAwarePredicate(this, startIndex, predicate);
    }

    public ConcreteReadOnlyListWithIndexAwarePredicateWithAction GetSelectiveConcreteNodesAsEnumerable(Func<Node, int, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithIndexAwarePredicateWithAction(this, startIndex, predicate, onChildRetrieval);
    }

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesAsEnumerable(predicate, startIndex, count);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsEnumerable(predicate, startIndex, count, onChildRetrieval);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<int, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesAsEnumerable(predicate, startIndex, count);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsEnumerable(predicate, startIndex, count, onChildRetrieval);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, int, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesAsEnumerable(predicate, startIndex, count);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerable(Func<INode, int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsEnumerable(predicate, startIndex, count, onChildRetrieval);

    public LooseReadOnlyListWithSimplePredicate GetSelectiveLooseNodesAsEnumerable(Func<INode, bool> predicate, int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new LooseReadOnlyListWithSimplePredicate(this, startIndex, startIndex + count, predicate);
    }

    public LooseReadOnlyListWithSimplePredicateWithAction GetSelectiveLooseNodesAsEnumerable(Func<INode, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new LooseReadOnlyListWithSimplePredicateWithAction(this, startIndex, startIndex + count, predicate, onChildRetrieval);
    }

    public LooseReadOnlyListWithIndexBasedPredicate GetSelectiveLooseNodesAsEnumerable(Func<int, bool> predicate, int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new LooseReadOnlyListWithIndexBasedPredicate(this, startIndex, startIndex + count, predicate);
    }

    public LooseReadOnlyListWithIndexBasedPredicateWithAction GetSelectiveLooseNodesAsEnumerable(Func<int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new LooseReadOnlyListWithIndexBasedPredicateWithAction(this, startIndex, startIndex + count, predicate, onChildRetrieval);
    }

    public LooseReadOnlyListWithIndexAwarePredicate GetSelectiveLooseNodesAsEnumerable(Func<INode, int, bool> predicate, int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new LooseReadOnlyListWithIndexAwarePredicate(this, startIndex, startIndex + count, predicate);
    }

    public LooseReadOnlyListWithIndexAwarePredicateWithAction GetSelectiveLooseNodesAsEnumerable(Func<INode, int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new LooseReadOnlyListWithIndexAwarePredicateWithAction(this, startIndex, startIndex + count, predicate, onChildRetrieval);
    }

    public ConcreteReadOnlyListWithSimplePredicate GetSelectiveConcreteNodesAsEnumerable(Func<Node, bool> predicate, int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new ConcreteReadOnlyListWithSimplePredicate(this, startIndex, startIndex + count, predicate);
    }

    public ConcreteReadOnlyListWithSimplePredicateWithAction GetSelectiveConcreteNodesAsEnumerable(Func<Node, bool> predicate, int startIndex, int count, Action<Node> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new ConcreteReadOnlyListWithSimplePredicateWithAction(this, startIndex, startIndex + count, predicate, onChildRetrieval);
    }

    public ConcreteReadOnlyListWithIndexBasedPredicate GetSelectiveConcreteNodesAsEnumerable(Func<int, bool> predicate, int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new ConcreteReadOnlyListWithIndexBasedPredicate(this, startIndex, startIndex + count, predicate);
    }

    public ConcreteReadOnlyListWithIndexBasedPredicateWithAction GetSelectiveConcreteNodesAsEnumerable(Func<int, bool> predicate, int startIndex, int count, Action<Node> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new ConcreteReadOnlyListWithIndexBasedPredicateWithAction(this, startIndex, startIndex + count, predicate, onChildRetrieval);
    }

    public ConcreteReadOnlyListWithIndexAwarePredicate GetSelectiveConcreteNodesAsEnumerable(Func<Node, int, bool> predicate, int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new ConcreteReadOnlyListWithIndexAwarePredicate(this, startIndex, startIndex + count, predicate);
    }

    public ConcreteReadOnlyListWithIndexAwarePredicateWithAction GetSelectiveConcreteNodesAsEnumerable(Func<Node, int, bool> predicate, int startIndex, int count, Action<Node> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }

        return new ConcreteReadOnlyListWithIndexAwarePredicateWithAction(this, startIndex, startIndex + count, predicate, onChildRetrieval);
    }

    public IEnumerable<INode> GetSelectiveNodesAsEnumerableOverRange(Func<INode, bool> predicate, int startIndex,
        int endIndex)
        => GetSelectiveLooseNodesAsEnumerableOverRange(predicate, startIndex, endIndex);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerableOverRange(Func<INode, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsEnumerableOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerableOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex)
        => GetSelectiveLooseNodesAsEnumerableOverRange(predicate, startIndex, endIndex);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerableOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsEnumerableOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerableOverRange(Func<INode, int, bool> predicate, int startIndex,
        int endIndex)
        => GetSelectiveLooseNodesAsEnumerableOverRange(predicate, startIndex, endIndex);

    public IEnumerable<INode> GetSelectiveNodesAsEnumerableOverRange(Func<INode, int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsEnumerableOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public LooseReadOnlyListWithSimplePredicate GetSelectiveLooseNodesAsEnumerableOverRange(Func<INode, bool> predicate, int startIndex, int endIndex)
    {
        return new LooseReadOnlyListWithSimplePredicate(this, startIndex, endIndex, predicate);
    }

    public LooseReadOnlyListWithSimplePredicateWithAction GetSelectiveLooseNodesAsEnumerableOverRange(Func<INode, bool> predicate, int startIndex, int endIndex, Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithSimplePredicateWithAction(this, startIndex, endIndex, predicate, onChildRetrieval);
    }

    public LooseReadOnlyListWithIndexBasedPredicate GetSelectiveLooseNodesAsEnumerableOverRange(Func<int, bool> predicate, int startIndex, int endIndex)
    {
        return new LooseReadOnlyListWithIndexBasedPredicate(this, startIndex, endIndex, predicate);
    }

    public LooseReadOnlyListWithIndexBasedPredicateWithAction GetSelectiveLooseNodesAsEnumerableOverRange(Func<int, bool> predicate, int startIndex, int endIndex, Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithIndexBasedPredicateWithAction(this, startIndex, endIndex, predicate, onChildRetrieval);
    }

    public LooseReadOnlyListWithIndexAwarePredicate GetSelectiveLooseNodesAsEnumerableOverRange(Func<INode, int, bool> predicate, int startIndex, int endIndex)
    {
        return new LooseReadOnlyListWithIndexAwarePredicate(this, startIndex, endIndex, predicate);
    }

    public LooseReadOnlyListWithIndexAwarePredicateWithAction GetSelectiveLooseNodesAsEnumerableOverRange(Func<INode, int, bool> predicate, int startIndex, int endIndex, Action<INode> onChildRetrieval)
    {
        return new LooseReadOnlyListWithIndexAwarePredicateWithAction(this, startIndex, endIndex, predicate, onChildRetrieval);
    }

    public ConcreteReadOnlyListWithSimplePredicate GetSelectiveConcreteNodesAsEnumerableOverRange(Func<Node, bool> predicate, int startIndex, int endIndex)
    {
        return new ConcreteReadOnlyListWithSimplePredicate(this, startIndex, endIndex, predicate);
    }

    public ConcreteReadOnlyListWithSimplePredicateWithAction GetSelectiveConcreteNodesAsEnumerableOverRange(Func<Node, bool> predicate, int startIndex, int endIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithSimplePredicateWithAction(this, startIndex, endIndex, predicate, onChildRetrieval);
    }

    public ConcreteReadOnlyListWithIndexBasedPredicate GetSelectiveConcreteNodesAsEnumerableOverRange(Func<int, bool> predicate, int startIndex, int endIndex)
    {
        return new ConcreteReadOnlyListWithIndexBasedPredicate(this, startIndex, endIndex, predicate);
    }

    public ConcreteReadOnlyListWithIndexBasedPredicateWithAction GetSelectiveConcreteNodesAsEnumerableOverRange(Func<int, bool> predicate, int startIndex, int endIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithIndexBasedPredicateWithAction(this, startIndex, endIndex, predicate, onChildRetrieval);
    }

    public ConcreteReadOnlyListWithIndexAwarePredicate GetSelectiveConcreteNodesAsEnumerableOverRange(Func<Node, int, bool> predicate, int startIndex, int endIndex)
    {
        return new ConcreteReadOnlyListWithIndexAwarePredicate(this, startIndex, endIndex, predicate);
    }

    public ConcreteReadOnlyListWithIndexAwarePredicateWithAction GetSelectiveConcreteNodesAsEnumerableOverRange(Func<Node, int, bool> predicate, int startIndex, int endIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteReadOnlyListWithIndexAwarePredicateWithAction(this, startIndex, endIndex, predicate, onChildRetrieval);
    }
}