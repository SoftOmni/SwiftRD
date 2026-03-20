using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public List<INode> RemoveChildren(List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }


    public List<INode> RemoveChildrenLoose(List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }


    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenConcrete(List<INode> children, Func<INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenConcrete(List<INode> children, Func<int, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenConcrete(List<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildren(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRange(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRange(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRange(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRange(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRange(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRange(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRangeLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRangeLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRangeLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRangeLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRangeLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> RemoveChildrenWithRangeLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenWithRangeConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenWithRangeConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenWithRangeConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenWithRangeConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenWithRangeConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> RemoveChildrenWithRangeConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval)
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public TReadOnlyList RemoveChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}