using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    
    public int InsertChildren(int index, IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, IEnumerator<INode> children, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, IEnumerator<INode> children, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }


    public int InsertChildrenLoose(int index, IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, IEnumerator<INode> children, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, IEnumerator<INode> children, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }


    public int InsertChildrenConcrete(int index, IEnumerator<Node> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, IEnumerator<Node> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, IEnumerator<INode> children, Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, IEnumerator<INode> children, Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int InsertChildrenLooseGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int InsertChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, IEnumerator<Node> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, IEnumerator<Node> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, IEnumerator<Node> children, int startIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, IEnumerator<Node> children, int startIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, IEnumerator<Node> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, IEnumerator<Node> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRange(int index, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeAsReversed(int index, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRange(int index, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeAsReversed(int index, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLoose(int index, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseAsReversed(int index, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLoose(int index, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseAsReversed(int index, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcrete(int index, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteAsReversed(int index, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcrete(int index, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteAsReversed(int index, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteGenericEnumeratorAsReversed<TEnumerator, TNode>(int index, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}