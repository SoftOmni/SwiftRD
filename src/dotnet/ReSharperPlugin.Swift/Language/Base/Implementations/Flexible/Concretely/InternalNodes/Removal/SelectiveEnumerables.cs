using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenConcrete(IEnumerable<INode> children, Func<INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenConcrete(IEnumerable<INode> children, Func<int, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenConcrete(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenWithRange(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenWithRange(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenWithRange(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenWithRange(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenWithRange(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenWithRange(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenWithRangeLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenWithRangeLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<INode> RemoveChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenWithRangeConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenWithRangeConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IEnumerable<Node> RemoveChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerable RemoveChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}