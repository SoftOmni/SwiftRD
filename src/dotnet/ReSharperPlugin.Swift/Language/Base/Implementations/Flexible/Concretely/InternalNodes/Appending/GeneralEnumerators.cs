using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public int AppendChildren(IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenLoose(IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenConcrete(IEnumerator<Node> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<INode> children, Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Action<INode> onChildAddition,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Action<Node> onChildAddition,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, Action<Node> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, Action<INode> onChildAddition,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}