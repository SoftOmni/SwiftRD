using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    internal List<INode> SetChildrenForcibly(IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerator<INode> children, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerator<INode> children, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }


    internal List<INode> SetChildrenLooseForcibly(IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerator<INode> children, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerator<INode> children, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }


    internal List<Node> SetChildrenConcreteForcibly(IEnumerator<Node> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerator<Node> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerator<Node> children, Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerator<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerator<Node> children, Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerator<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal List<Node> SetChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal List<Node> SetChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Action<Node, Node> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, Action<Node, Node> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerator<Node> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerator<Node> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerator<Node> children, int startIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerator<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerator<Node> children, int startIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerator<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenLooseForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerator<Node> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerator<Node> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node, Node> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteForcibly(IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node, Node> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteAndDiscardForcibly(IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeLooseForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeLooseForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildrenWithRangeLooseForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseAndDiscardForcibly(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteAndDiscardForcibly(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteAndDiscardForcibly(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteAndDiscardForcibly(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeLooseGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildrenWithRangeConcreteGenericEnumeratorAndDiscardForcibly<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}