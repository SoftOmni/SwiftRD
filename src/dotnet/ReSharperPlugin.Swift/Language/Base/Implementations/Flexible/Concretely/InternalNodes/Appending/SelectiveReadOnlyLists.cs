using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public int AppendChildren(IReadOnlyList<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<INode> children, Func<INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<INode> children, Func<int, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<Node> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<Node> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IReadOnlyList<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IReadOnlyList<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IReadOnlyList<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IReadOnlyList<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IReadOnlyList<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IReadOnlyList<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete<TReadOnlyList, TNode>(TReadOnlyList children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}