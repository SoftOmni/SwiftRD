using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenConcreteForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenConcreteForcibly(IEnumerable<INode> children, Func<int, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenConcreteForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenWithRangeForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenWithRangeForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenWithRangeForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenWithRangeForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenWithRangeForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenWithRangeForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenWithRangeLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenWithRangeLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenWithRangeLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenWithRangeLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenWithRangeLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<INode> RemoveChildrenWithRangeLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IEnumerable<Node> RemoveChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerable RemoveChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}