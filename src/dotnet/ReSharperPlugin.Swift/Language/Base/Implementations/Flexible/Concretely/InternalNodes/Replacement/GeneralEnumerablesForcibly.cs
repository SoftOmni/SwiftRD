using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerable<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerable<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerable<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerable<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerable<Node> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerable<Node> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerable<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerable<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerable<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerable<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal List<INode> ReplaceChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal List<Node> ReplaceChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteGenericEnumerableAndDiscardForcibly<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}