using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public int InsertChildren(int index, List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }


    public int InsertChildrenLoose(int index, List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }


    public int InsertChildrenConcrete(int index, List<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<INode> children, Func<INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<INode> children, Func<INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<INode> children, Func<int, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<INode> children, Func<int, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildren(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLoose(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcrete(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRange(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRange(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRange(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRange(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRange(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRange(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLoose(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLoose(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLoose(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLoose(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseAsReversed(int index, List<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLoose(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseAsReversed(int index, List<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLoose(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseAsReversed(int index, List<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcrete(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcrete(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcrete(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcrete(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteAsReversed(int index, List<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcrete(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteAsReversed(int index, List<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcrete(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteAsReversed(int index, List<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeLooseWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteWithConcreteList<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int InsertChildrenWithRangeConcreteWithConcreteListAsReversed<TReadOnlyList, TNode>(int index, TReadOnlyList children, Func<int, TNode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
        where TReadOnlyList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}