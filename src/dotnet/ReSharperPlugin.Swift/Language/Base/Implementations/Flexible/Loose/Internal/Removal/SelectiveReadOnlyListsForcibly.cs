using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }


    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }


    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenConcreteForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenConcreteForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenConcreteForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenWithRangeForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenWithRangeForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenWithRangeForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenWithRangeForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenWithRangeForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenWithRangeForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> RemoveChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> RemoveChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList RemoveChildrenWithRangeConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}