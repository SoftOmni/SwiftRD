using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenConcrete(IEnumerator<INode> children, Func<INode, bool> predicate, Action<Node> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenConcrete(IEnumerator<INode> children, Func<int, bool> predicate, Action<Node> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenConcrete(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenWithRange(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenWithRange(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenWithRange(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenWithRange(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenWithRange(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenWithRange(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenWithRangeLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenWithRangeLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenWithRangeLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenWithRangeLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenWithRangeLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<INode> RemoveChildrenWithRangeLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenWithRangeConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenWithRangeConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenWithRangeConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenWithRangeConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenWithRangeConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<Node> RemoveChildrenWithRangeConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TEnumerator RemoveChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}