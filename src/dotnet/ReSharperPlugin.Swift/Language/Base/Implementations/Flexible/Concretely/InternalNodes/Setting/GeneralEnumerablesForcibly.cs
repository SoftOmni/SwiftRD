using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    internal List<INode> SetChildrenForcibly(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerable<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerable<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerable<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerable<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerable<Node> children)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerable<Node> children)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerable<Node> children, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerable<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerable<Node> children, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerable<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal List<INode> SetChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal List<Node> SetChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerable<Node> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerable<Node> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerable<Node> children, int startIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerable<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerable<Node> children, int startIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerable<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerable<Node> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerable<Node> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeLooseForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeLooseForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeLooseForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseAndDiscardForcibly(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteAndDiscardForcibly(IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteAndDiscardForcibly(IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteAndDiscardForcibly(IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}