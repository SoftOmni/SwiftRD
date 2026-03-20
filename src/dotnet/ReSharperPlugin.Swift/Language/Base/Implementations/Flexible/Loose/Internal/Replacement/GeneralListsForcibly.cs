using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, List<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, List<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, List<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, List<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, List<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, List<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, List<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, List<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, List<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, List<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, List<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, List<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, List<Node> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, List<Node> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, List<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, List<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, List<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, List<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenLooseForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, int count, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, int count, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteAndDiscardForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenLooseWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenLooseWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenConcreteWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenConcreteWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeLooseForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseAndDiscardForcibly(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeConcreteForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeConcreteForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<INode> ReplaceChildrenWithRangeConcreteForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteAndDiscardForcibly(int indexOfReplacement, List<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeLooseWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        int endIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        int endIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeLooseWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        int endIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeLooseWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        int endIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        int endIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeLooseWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        int endIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        int endIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        int endIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        int endIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal List<Node> ReplaceChildrenWithRangeConcreteWithConcreteListForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        int endIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        int endIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal void ReplaceChildrenWithRangeConcreteWithConcreteListAndDiscardForcibly<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection,
        int endIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}