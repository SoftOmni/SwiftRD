using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public List<INode> DetachChildren(List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }


    public List<INode> DetachChildrenLoose(List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }


    public List<Node> DetachChildrenConcrete(List<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenConcrete(List<INode> children, Func<INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenConcrete(List<INode> children, Func<int, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenConcrete(List<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildren(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRange(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRange(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRange(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRange(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRange(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRange(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRangeLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRangeLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRangeLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRangeLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRangeLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> DetachChildrenWithRangeLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenWithRangeConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenWithRangeConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenWithRangeConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenWithRangeConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenWithRangeConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> DetachChildrenWithRangeConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList DetachChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}