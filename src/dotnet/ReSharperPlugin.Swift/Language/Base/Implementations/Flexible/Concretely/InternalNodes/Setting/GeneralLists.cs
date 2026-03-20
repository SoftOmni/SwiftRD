using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public List<INode> SetChildren(List<INode> children)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(List<INode> children)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(List<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(List<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(List<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(List<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(List<INode> children)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(List<INode> children)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(List<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(List<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(List<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(List<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(List<Node> children)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(List<Node> children)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(List<Node> children, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(List<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(List<Node> children, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(List<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithConcreteList<TList, TNode>(TList children)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithConcreteListAndDiscard<TList, TNode>(TList children)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithConcreteList<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithConcreteList<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithConcreteListAndDiscard<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithConcreteListAndDiscard<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseWithConcreteList<TList, TNode>(TList children)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseWithConcreteListAndDiscard<TList, TNode>(TList children)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseWithConcreteList<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseWithConcreteList<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseWithConcreteListAndDiscard<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseWithConcreteListAndDiscard<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteWithConcreteList<TList, TNode>(TList children)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(TList children)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteWithConcreteList<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteWithConcreteList<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(List<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(List<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(List<INode> children, int startIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(List<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(List<INode> children, int startIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(List<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(List<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(List<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(List<INode> children, int startIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(List<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(List<INode> children, int startIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(List<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(List<Node> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(List<Node> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(List<Node> children, int startIndexInCollection, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(List<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(List<Node> children, int startIndexInCollection, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(List<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithConcreteList<TList, TNode>(TList children, int startIndexInCollection)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseWithConcreteList<TList, TNode>(TList children, int startIndexInCollection)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteWithConcreteList<TList, TNode>(TList children, int startIndexInCollection)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(List<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(List<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(List<INode> children, int startIndexInCollection, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(List<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(List<INode> children, int startIndexInCollection, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(List<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(List<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(List<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(List<INode> children, int startIndexInCollection, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(List<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(List<INode> children, int startIndexInCollection, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(List<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(List<Node> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(List<Node> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(List<Node> children, int startIndexInCollection, int count, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(List<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(List<Node> children, int startIndexInCollection, int count, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(List<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int count,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int count,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard(List<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard(List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard(List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeLoose(List<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard(List<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeLoose(List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeLoose(List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard(List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard(List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeConcrete(List<Node> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard(List<Node> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete(List<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete(List<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard(List<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard(List<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLooseWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLooseWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLooseWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcreteWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcreteWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcreteWithConcreteList<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteWithConcreteListAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}