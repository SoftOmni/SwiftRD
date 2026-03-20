using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    internal List<INode> SetChildrenForcibly(IReadOnlyList<INode> children)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IReadOnlyList<INode> children)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IReadOnlyList<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IReadOnlyList<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IReadOnlyList<INode> children)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IReadOnlyList<INode> children)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IReadOnlyList<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IReadOnlyList<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IReadOnlyList<Node> children)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IReadOnlyList<Node> children)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IReadOnlyList<Node> children, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IReadOnlyList<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IReadOnlyList<Node> children, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IReadOnlyList<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenForcibly<TList, TNode>(TList children)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly<TList, TNode>(TList children)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenForcibly<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenForcibly<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseForcibly<TList, TNode>(TList children)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly<TList, TNode>(TList children)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseForcibly<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseForcibly<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly<TList, TNode>(TList children)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly<TList, TNode>(TList children)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly<TList, TNode>(TList children, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly<TList, TNode>(TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IReadOnlyList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IReadOnlyList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenConcreteForcibly(IReadOnlyList<Node> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IReadOnlyList<Node> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IReadOnlyList<Node> children, int startIndexInCollection, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IReadOnlyList<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IReadOnlyList<Node> children, int startIndexInCollection, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IReadOnlyList<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenForcibly<TList, TNode>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenForcibly<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenForcibly<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseForcibly<TList, TNode>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseForcibly<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseForcibly<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly<TList, TNode>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IReadOnlyList<Node> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IReadOnlyList<Node> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenForcibly<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenForcibly<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenForcibly<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseForcibly<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseForcibly<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseForcibly<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int count)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeLooseForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseAndDiscardForcibly(IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteAndDiscardForcibly(IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteForcibly(IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteAndDiscardForcibly(IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteAndDiscardForcibly(IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeLooseForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeLooseForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeLooseForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteAndDiscardForcibly<TList, TNode>(TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}