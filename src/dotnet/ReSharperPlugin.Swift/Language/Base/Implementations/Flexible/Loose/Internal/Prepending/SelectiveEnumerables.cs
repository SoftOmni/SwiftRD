using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public void PrependChildren(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }
    
    public void PrependChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }
    
    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<INode> children, Func<INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<INode> children, Func<int, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteAsReversed(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRange(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRange(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRange(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRange(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRange(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRange(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseAsReversed(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseAsReversed(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseAsReversed(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteAsReversed(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteAsReversed(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteAsReversed(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteAsReversed(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteAsReversed(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteAsReversed(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeLooseGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void PrependChildrenWithRangeConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}