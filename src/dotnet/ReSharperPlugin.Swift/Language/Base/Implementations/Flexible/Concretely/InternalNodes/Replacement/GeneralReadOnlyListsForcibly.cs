using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IReadOnlyList<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IReadOnlyList<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IReadOnlyList<Node> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<Node> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IReadOnlyList<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IReadOnlyList<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenForcibly<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseForcibly<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeLooseForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeLooseForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeLooseForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}