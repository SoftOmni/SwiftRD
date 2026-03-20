using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public int AttachChildren(int index, IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IEnumerable<INode> children, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, IEnumerable<INode> children, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }


    public int AttachChildrenLoose(int index, IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, IEnumerable<INode> children, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, IEnumerable<INode> children, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }


    public int AttachChildrenConcrete(int index, IEnumerable<Node> children)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, IEnumerable<Node> children)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, IEnumerable<INode> children, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, IEnumerable<INode> children, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AttachChildrenLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AttachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, IEnumerable<Node> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, IEnumerable<Node> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, IEnumerable<Node> children, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, IEnumerable<Node> children, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, IEnumerable<Node> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, IEnumerable<Node> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLoose(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLoose(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcrete(int index, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteAsReversed(int index, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcrete(int index, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteAsReversed(int index, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}