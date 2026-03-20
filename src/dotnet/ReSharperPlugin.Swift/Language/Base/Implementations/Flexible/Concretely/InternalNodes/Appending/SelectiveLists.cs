using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public int AppendChildren(List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenLoose(List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenConcrete(List<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<INode> children, Func<INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<INode> children, Func<int, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}