using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }


    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }


    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenConcrete(IReadOnlyList<INode> children, Func<INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenConcrete(IReadOnlyList<INode> children, Func<int, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenConcrete(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildren(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenWithRange(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenWithRange(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenWithRange(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenWithRange(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenWithRange(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenWithRange(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenWithRangeLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenWithRangeLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenWithRangeLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenWithRangeLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenWithRangeLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<INode> DetachChildrenWithRangeLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenWithRangeConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenWithRangeConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenWithRangeConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenWithRangeConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenWithRangeConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyList<Node> DetachChildrenWithRangeConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRange<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRange<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRange<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRange<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRange<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRange<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}