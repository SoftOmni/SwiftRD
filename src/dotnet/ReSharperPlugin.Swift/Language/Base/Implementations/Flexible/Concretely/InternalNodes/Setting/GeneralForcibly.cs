using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    internal List<INode> SetChildForcibly(INode child)
    {
        throw new NotImplementedException();
    }
    
    internal void SetChildAndDiscardForcibly(INode child)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildForcibly(INode child, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildForcibly(INode child, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildAndDiscardForcibly(INode child, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildAndDiscardForcibly(INode child, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildLooseForcibly(INode child)
    {
        throw new NotImplementedException();
    }

    internal void SetChildLooseAndDiscardForcibly(INode child)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildLooseForcibly(INode child, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<INode> SetChildLooseForcibly(INode child, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildLooseAndDiscardForcibly(INode child, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildLooseAndDiscardForcibly(INode child, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildConcreteForcibly(Node child)
    {
        throw new NotImplementedException();
    }

    internal void SetChildConcreteAndDiscardForcibly(Node child)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildConcreteForcibly(Node child, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildConcreteForcibly(Node child, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildConcreteAndDiscardForcibly(Node child, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    internal void SetChildConcreteAndDiscardForcibly(Node child, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildForcibly<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildAndDiscardForcibly<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildForcibly<TNode>(TNode child, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildForcibly<TNode>(TNode child, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildAndDiscardForcibly<TNode>(TNode child, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildAndDiscardForcibly<TNode>(TNode child, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildLooseForcibly<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildLooseAndDiscardForcibly<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildLooseForcibly<TNode>(TNode child, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildLooseForcibly<TNode>(TNode child, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildLooseAndDiscardForcibly<TNode>(TNode child, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void SetChildLooseAndDiscardForcibly<TNode>(TNode child, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildConcreteForcibly<TNode>(TNode child)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildConcreteAndDiscardForcibly<TNode>(TNode child)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildConcreteForcibly<TNode>(TNode child, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> SetChildConcreteForcibly<TNode>(TNode child, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildConcreteAndDiscardForcibly<TNode>(TNode child, Action<TNode, TNode> actionOnAdditionAndRemoval)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void SetChildConcreteAndDiscardForcibly<TNode>(TNode child, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : Node
    {
        throw new NotImplementedException();
    }
}