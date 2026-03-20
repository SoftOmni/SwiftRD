using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public int InsertChildren(int index, IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, IEnumerable<INode> children, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, IEnumerable<INode> children, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }


    public int InsertChildrenLoose(int index, IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, IEnumerable<INode> children, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, IEnumerable<INode> children, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }


    public int InsertChildrenConcrete(int index, IEnumerable<Node> children)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, IEnumerable<Node> children)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, IEnumerable<INode> children, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, IEnumerable<INode> children, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int InsertChildrenLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int InsertChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, IEnumerable<Node> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, IEnumerable<Node> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, IEnumerable<Node> children, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, IEnumerable<Node> children, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, IEnumerable<Node> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, IEnumerable<Node> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRange(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRange(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLoose(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLoose(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseAsReversed(int index, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcrete(int index, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteAsReversed(int index, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcrete(int index, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteAsReversed(int index, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteGenericEnumerableAsReversed<TEnumerable, TNode>(int index, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}