using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerator<INode> children, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerator<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }


    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerator<INode> children, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerator<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }


    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerator<Node> children, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerator<Node> children, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerator<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerator<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerator<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerator<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal List<Node> ReplaceChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal List<Node> ReplaceChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<Node, Node?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<Node, Node?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int count, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int count, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node, Node?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node, Node?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}