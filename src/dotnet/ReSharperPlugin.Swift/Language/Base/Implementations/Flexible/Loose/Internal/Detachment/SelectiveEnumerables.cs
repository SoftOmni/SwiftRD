using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenConcrete(IEnumerable<INode> children, Func<INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenConcrete(IEnumerable<INode> children, Func<int, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenConcrete(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenWithRange(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenWithRange(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenWithRange(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenWithRange(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenWithRange(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenWithRange(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenWithRangeLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenWithRangeLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> DetachChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenWithRangeConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenWithRangeConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> DetachChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable DetachChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}