using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public List<INode> SetChildren(IReadOnlyList<INode> children)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IReadOnlyList<INode> children)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren(IReadOnlyList<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren(IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IReadOnlyList<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IReadOnlyList<INode> children)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IReadOnlyList<INode> children)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IReadOnlyList<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IReadOnlyList<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IReadOnlyList<Node> children)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IReadOnlyList<Node> children)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IReadOnlyList<Node> children, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IReadOnlyList<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IReadOnlyList<Node> children, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IReadOnlyList<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren<TList, TNode>(TList children)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard<TList, TNode>(TList children)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLoose<TList, TNode>(TList children)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard<TList, TNode>(TList children)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLoose<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLoose<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete<TList, TNode>(TList children)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard<TList, TNode>(TList children)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(IReadOnlyList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IReadOnlyList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenConcrete(IReadOnlyList<Node> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IReadOnlyList<Node> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IReadOnlyList<Node> children, int startIndexInCollection, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IReadOnlyList<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IReadOnlyList<Node> children, int startIndexInCollection, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IReadOnlyList<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren<TList, TNode>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard<TList, TNode>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLoose<TList, TNode>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard<TList, TNode>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLoose<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLoose<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete<TList, TNode>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard<TList, TNode>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(IReadOnlyList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IReadOnlyList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IReadOnlyList<Node> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IReadOnlyList<Node> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLoose<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLoose<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLoose<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRange(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRange(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRange(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeLoose(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLoose(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLoose(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete(IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard(IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete(IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete(IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard(IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard(IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRange<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRange<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRange<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLoose<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLoose<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLoose<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}