using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }


    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }


    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenConcrete(IEnumerator<INode> children, Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Action<Node> onChildRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, Action<Node> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRangeLoose(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRangeLoose(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenWithRangeConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenWithRangeConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}