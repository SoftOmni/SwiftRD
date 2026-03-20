using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenConcrete(IEnumerator<INode> children, Func<INode, bool> predicate, Action<Node> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenConcrete(IEnumerator<INode> children, Func<int, bool> predicate, Action<Node> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenConcrete(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRange(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRange(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRange(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRange(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRange(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRange(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRangeLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRangeLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRangeLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRangeLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRangeLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> DetachChildrenWithRangeLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenWithRangeConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenWithRangeConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenWithRangeConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenWithRangeConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenWithRangeConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> DetachChildrenWithRangeConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator DetachChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}