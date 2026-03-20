using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }


    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }


    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenConcreteForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenConcreteForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenConcreteForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenWithRangeForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenWithRangeForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenWithRangeForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenWithRangeForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenWithRangeForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenWithRangeForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<INode> DetachChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal IReadOnlyList<Node> DetachChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeLooseForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TReadOnlyList DetachChildrenWithRangeConcreteForcibly<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}