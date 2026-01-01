using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.InternalNodes;

public partial class InternalNode
{
    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, bool> predicate)
        => GetSelectiveLooseNodesEnumerator(predicate);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesEnumerator(predicate, onChildRetrieval);
    
    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<int, bool> predicate)
        => GetSelectiveLooseNodesEnumerator(predicate);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<int, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesEnumerator(predicate, onChildRetrieval);
    
    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, int, bool> predicate)
        => GetSelectiveLooseNodesEnumerator(predicate);
    
    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesEnumerator(predicate, onChildRetrieval);

    public LooseEnumeratorWithSimplePredicate GetSelectiveLooseNodesEnumerator(Func<INode, bool> predicate)
    {
        return new LooseEnumeratorWithSimplePredicate(this, predicate);
    }

    public LooseEnumeratorWithSimplePredicateWithAction GetSelectiveLooseNodesEnumerator(Func<INode, bool> predicate, Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithSimplePredicateWithAction(this, predicate, onChildRetrieval);
    }

    public LooseEnumeratorWithIndexBasedPredicate GetSelectiveLooseNodesEnumerator(Func<int, bool> predicate)
    {
        return new LooseEnumeratorWithIndexBasedPredicate(this, predicate);
    }

    public LooseEnumeratorWithIndexBasedPredicateWithAction GetSelectiveLooseNodesEnumerator(Func<int, bool> predicate, Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithIndexBasedPredicateWithAction(this, predicate, onChildRetrieval);
    }

    public LooseEnumeratorWithIndexAwarePredicate GetSelectiveLooseNodesEnumerator(Func<INode, int, bool> predicate)
    {
        return new LooseEnumeratorWithIndexAwarePredicate(this, predicate);
    }

    public LooseEnumeratorWithIndexAwarePredicateWithAction GetSelectiveLooseNodesEnumerator(Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithIndexAwarePredicateWithAction(this, predicate, onChildRetrieval);
    }
    
    public ConcreteEnumeratorWithSimplePredicate GetSelectiveConcreteNodesEnumerator(Func<Node, bool> predicate)
    {
        return new ConcreteEnumeratorWithSimplePredicate(this, predicate);
    }
    
    public ConcreteEnumeratorWithSimplePredicateWithAction GetSelectiveConcreteNodesEnumerator(Func<Node, bool> predicate, Action<Node> onChildRetrieval)
    {
        return new ConcreteEnumeratorWithSimplePredicateWithAction(this, predicate, onChildRetrieval);
    }
    
    public ConcreteEnumeratorWithIndexBasedPredicate GetSelectiveConcreteNodesEnumerator(Func<int, bool> predicate)
    {
        return new ConcreteEnumeratorWithIndexBasedPredicate(this, predicate);
    }
    
    public ConcreteEnumeratorWithIndexBasedPredicateWithAction GetSelectiveConcreteNodesEnumerator(Func<int, bool> predicate, Action<Node> onChildRetrieval)
    {
        return new ConcreteEnumeratorWithIndexBasedPredicateWithAction(this, predicate, onChildRetrieval);
    }
    
    public ConcreteEnumeratorWithIndexAwarePredicate GetSelectiveConcreteNodesEnumerator(Func<Node, int, bool> predicate)
    {
        return new ConcreteEnumeratorWithIndexAwarePredicate(this, predicate);
    }
    
    public ConcreteEnumeratorWithIndexAwarePredicateWithAction GetSelectiveConcreteNodesEnumerator(Func<Node, int, bool> predicate, Action<Node> onChildRetrieval)
    {
        return new ConcreteEnumeratorWithIndexAwarePredicateWithAction(this, predicate, onChildRetrieval);
    }

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesEnumerator(predicate, startIndex);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesEnumerator(predicate, startIndex, onChildRetrieval);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<int, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesEnumerator(predicate, startIndex);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesEnumerator(predicate, startIndex, onChildRetrieval);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, int, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesEnumerator(predicate, startIndex);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesEnumerator(predicate, startIndex, onChildRetrieval);

    public LooseEnumeratorWithSimplePredicate GetSelectiveLooseNodesEnumerator(Func<INode, bool> predicate, int startIndex)
    {
        return new LooseEnumeratorWithSimplePredicate(this, startIndex, predicate);
    }

    public LooseEnumeratorWithSimplePredicateWithAction GetSelectiveLooseNodesEnumerator(Func<INode, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithSimplePredicateWithAction(this, startIndex, predicate, onChildRetrieval);
    }

    public LooseEnumeratorWithIndexBasedPredicate GetSelectiveLooseNodesEnumerator(Func<int, bool> predicate, int startIndex)
    {
        return new LooseEnumeratorWithIndexBasedPredicate(this, startIndex, predicate);
    }

    public LooseEnumeratorWithIndexBasedPredicateWithAction GetSelectiveLooseNodesEnumerator(Func<int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithIndexBasedPredicateWithAction(this, startIndex, predicate, onChildRetrieval);
    }

    public LooseEnumeratorWithIndexAwarePredicate GetSelectiveLooseNodesEnumerator(Func<INode, int, bool> predicate, int startIndex)
    {
        return new LooseEnumeratorWithIndexAwarePredicate(this, startIndex, predicate);
    }

    public LooseEnumeratorWithIndexAwarePredicateWithAction GetSelectiveLooseNodesEnumerator(Func<INode, int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithIndexAwarePredicateWithAction(this, startIndex, predicate, onChildRetrieval);
    }

    public ConcreteEnumeratorWithSimplePredicate GetSelectiveConcreteNodesEnumerator(Func<Node, bool> predicate, int startIndex)
    {
        return new ConcreteEnumeratorWithSimplePredicate(this, startIndex, predicate);
    }

    public ConcreteEnumeratorWithSimplePredicateWithAction GetSelectiveConcreteNodesEnumerator(Func<Node, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteEnumeratorWithSimplePredicateWithAction(this, startIndex, predicate, onChildRetrieval);
    }

    public ConcreteEnumeratorWithIndexBasedPredicate GetSelectiveConcreteNodesEnumerator(Func<int, bool> predicate, int startIndex)
    {
        return new ConcreteEnumeratorWithIndexBasedPredicate(this, startIndex, predicate);
    }

    public ConcreteEnumeratorWithIndexBasedPredicateWithAction GetSelectiveConcreteNodesEnumerator(Func<int, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteEnumeratorWithIndexBasedPredicateWithAction(this, startIndex, predicate, onChildRetrieval);
    }

    public ConcreteEnumeratorWithIndexAwarePredicate GetSelectiveConcreteNodesEnumerator(Func<Node, int, bool> predicate, int startIndex)
    {
        return new ConcreteEnumeratorWithIndexAwarePredicate(this, startIndex, predicate);
    }

    public ConcreteEnumeratorWithIndexAwarePredicateWithAction GetSelectiveConcreteNodesEnumerator(Func<Node, int, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteEnumeratorWithIndexAwarePredicateWithAction(this, startIndex, predicate, onChildRetrieval);
    }

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesEnumerator(predicate, startIndex, count);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesEnumerator(predicate, startIndex, count, onChildRetrieval);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<int, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesEnumerator(predicate, startIndex, count);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesEnumerator(predicate, startIndex, count, onChildRetrieval);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, int, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesEnumerator(predicate, startIndex, count);

    public IEnumerator<INode> GetSelectiveNodesEnumerator(Func<INode, int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesEnumerator(predicate, startIndex, count, onChildRetrieval);

    public LooseEnumeratorWithSimplePredicate GetSelectiveLooseNodesEnumerator(Func<INode, bool> predicate, int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new LooseEnumeratorWithSimplePredicate(this, startIndex, startIndex + count, predicate);
    }

    public LooseEnumeratorWithSimplePredicateWithAction GetSelectiveLooseNodesEnumerator(Func<INode, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new LooseEnumeratorWithSimplePredicateWithAction(this, startIndex, startIndex + count, predicate, onChildRetrieval);
    }

    public LooseEnumeratorWithIndexBasedPredicate GetSelectiveLooseNodesEnumerator(Func<int, bool> predicate, int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new LooseEnumeratorWithIndexBasedPredicate(this, startIndex, startIndex + count, predicate);
    }

    public LooseEnumeratorWithIndexBasedPredicateWithAction GetSelectiveLooseNodesEnumerator(Func<int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new LooseEnumeratorWithIndexBasedPredicateWithAction(this, startIndex, startIndex + count, predicate, onChildRetrieval);
    }

    public LooseEnumeratorWithIndexAwarePredicate GetSelectiveLooseNodesEnumerator(Func<INode, int, bool> predicate, int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new LooseEnumeratorWithIndexAwarePredicate(this, startIndex, startIndex + count, predicate);
    }

    public LooseEnumeratorWithIndexAwarePredicateWithAction GetSelectiveLooseNodesEnumerator(Func<INode, int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new LooseEnumeratorWithIndexAwarePredicateWithAction(this, startIndex, startIndex + count, predicate, onChildRetrieval);
    }

    public ConcreteEnumeratorWithSimplePredicate GetSelectiveConcreteNodesEnumerator(Func<Node, bool> predicate, int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new ConcreteEnumeratorWithSimplePredicate(this, startIndex, startIndex + count, predicate);
    }

    public ConcreteEnumeratorWithSimplePredicateWithAction GetSelectiveConcreteNodesEnumerator(Func<Node, bool> predicate, int startIndex, int count, Action<Node> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new ConcreteEnumeratorWithSimplePredicateWithAction(this, startIndex, startIndex + count, predicate, onChildRetrieval);
    }

    public ConcreteEnumeratorWithIndexBasedPredicate GetSelectiveConcreteNodesEnumerator(Func<int, bool> predicate, int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new ConcreteEnumeratorWithIndexBasedPredicate(this, startIndex, startIndex + count, predicate);
    }

    public ConcreteEnumeratorWithIndexBasedPredicateWithAction GetSelectiveConcreteNodesEnumerator(Func<int, bool> predicate, int startIndex, int count, Action<Node> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new ConcreteEnumeratorWithIndexBasedPredicateWithAction(this, startIndex, startIndex + count, predicate, onChildRetrieval);
    }

    public ConcreteEnumeratorWithIndexAwarePredicate GetSelectiveConcreteNodesEnumerator(Func<Node, int, bool> predicate, int startIndex, int count)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new ConcreteEnumeratorWithIndexAwarePredicate(this, startIndex, startIndex + count, predicate);
    }

    public ConcreteEnumeratorWithIndexAwarePredicateWithAction GetSelectiveConcreteNodesEnumerator(Func<Node, int, bool> predicate, int startIndex, int count, Action<Node> onChildRetrieval)
    {
        if (count < 0)
        {
            throw new ArgumentOutOfRangeException(nameof(count));
        }
        
        return new ConcreteEnumeratorWithIndexAwarePredicateWithAction(this, startIndex, startIndex + count, predicate, onChildRetrieval);
    }

    public IEnumerator<INode> GetSelectiveNodesEnumeratorOverRange(Func<INode, bool> predicate, int startIndex,
        int endIndex)
        => GetSelectiveLooseNodesEnumeratorOverRange(predicate, startIndex, endIndex);

    public IEnumerator<INode> GetSelectiveNodesEnumeratorOverRange(Func<INode, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesEnumeratorOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public IEnumerator<INode> GetSelectiveNodesEnumeratorOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex)
        => GetSelectiveLooseNodesEnumeratorOverRange(predicate, startIndex, endIndex);

    public IEnumerator<INode> GetSelectiveNodesEnumeratorOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesEnumeratorOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public IEnumerator<INode> GetSelectiveNodesEnumeratorOverRange(Func<INode, int, bool> predicate, int startIndex,
        int endIndex)
        => GetSelectiveLooseNodesEnumeratorOverRange(predicate, startIndex, endIndex);

    public IEnumerator<INode> GetSelectiveNodesEnumeratorOverRange(Func<INode, int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesEnumeratorOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public LooseEnumeratorWithSimplePredicate GetSelectiveLooseNodesEnumeratorOverRange(Func<INode, bool> predicate, int startIndex,
        int endIndex)
    {
        return new LooseEnumeratorWithSimplePredicate(this, startIndex, endIndex, predicate);
    }

    public LooseEnumeratorWithSimplePredicateWithAction GetSelectiveLooseNodesEnumeratorOverRange(Func<INode, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithSimplePredicateWithAction(this, startIndex, endIndex, predicate, onChildRetrieval);
    }
    
    public LooseEnumeratorWithIndexBasedPredicate GetSelectiveLooseNodesEnumeratorOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex)
    {
        return new LooseEnumeratorWithIndexBasedPredicate(this, startIndex, endIndex, predicate);
    }

    public LooseEnumeratorWithIndexBasedPredicateWithAction GetSelectiveLooseNodesEnumeratorOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithIndexBasedPredicateWithAction(this, startIndex, endIndex, predicate, onChildRetrieval);
    }
    
    public LooseEnumeratorWithIndexAwarePredicate GetSelectiveLooseNodesEnumeratorOverRange(Func<INode, int, bool> predicate, int startIndex,
        int endIndex)
    {
        return new LooseEnumeratorWithIndexAwarePredicate(this, startIndex, endIndex, predicate);
    }
    
    public LooseEnumeratorWithIndexAwarePredicateWithAction GetSelectiveLooseNodesEnumeratorOverRange(Func<INode, int, bool> predicate, int startIndex,
        int endIndex, Action<INode> onChildRetrieval)
    {
        return new LooseEnumeratorWithIndexAwarePredicateWithAction(this, startIndex, endIndex, predicate, onChildRetrieval);
    }
    
    public ConcreteEnumeratorWithSimplePredicate GetSelectiveConcreteNodesEnumeratorOverRange(Func<Node, bool> predicate, int startIndex,
        int endIndex)
    {
        return new ConcreteEnumeratorWithSimplePredicate(this, startIndex, endIndex, predicate);
    }
    
    public ConcreteEnumeratorWithSimplePredicateWithAction GetSelectiveConcreteNodesEnumeratorOverRange(Func<Node, bool> predicate, int startIndex,
        int endIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteEnumeratorWithSimplePredicateWithAction(this, startIndex, endIndex, predicate, onChildRetrieval);
    }
    
    public ConcreteEnumeratorWithIndexBasedPredicate GetSelectiveConcreteNodesEnumeratorOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex)
    {
        return new ConcreteEnumeratorWithIndexBasedPredicate(this, startIndex, endIndex, predicate);
    }
    
    public ConcreteEnumeratorWithIndexBasedPredicateWithAction GetSelectiveConcreteNodesEnumeratorOverRange(Func<int, bool> predicate, int startIndex,
        int endIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteEnumeratorWithIndexBasedPredicateWithAction(this, startIndex, endIndex, predicate, onChildRetrieval);
    }
    
    public ConcreteEnumeratorWithIndexAwarePredicate GetSelectiveConcreteNodesEnumeratorOverRange(Func<Node, int, bool> predicate, int startIndex,
        int endIndex)
    {
        return new ConcreteEnumeratorWithIndexAwarePredicate(this, startIndex, endIndex, predicate);
    }
    
    public ConcreteEnumeratorWithIndexAwarePredicateWithAction GetSelectiveConcreteNodesEnumeratorOverRange(Func<Node, int, bool> predicate, int startIndex,
        int endIndex, Action<Node> onChildRetrieval)
    {
        return new ConcreteEnumeratorWithIndexAwarePredicateWithAction(this, startIndex, endIndex, predicate, onChildRetrieval);
    }
}