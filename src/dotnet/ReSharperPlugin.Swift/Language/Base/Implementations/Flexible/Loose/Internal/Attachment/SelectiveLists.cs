using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public int AttachChildren(int index, List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }


    public int AttachChildrenLoose(int index, List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }


    public int AttachChildrenConcrete(int index, List<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<INode> children, Func<INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<INode> children, Func<INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<INode> children, Func<int, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<INode> children, Func<int, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildren(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLoose(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcrete(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRange(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLoose(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLoose(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLoose(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLoose(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLoose(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLoose(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcrete(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcrete(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcrete(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcrete(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcrete(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcrete(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AttachChildrenWithRangeConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}