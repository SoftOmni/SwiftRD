using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public List<INode> ReplaceChildren(int indexOfReplacement, List<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, List<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, List<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, List<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, List<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, List<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, List<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, List<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, List<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, List<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, List<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, List<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, List<Node> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, List<Node> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, List<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, List<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, List<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, List<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, List<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, List<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, List<Node> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, List<Node> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, List<Node> children, int startIndexInCollection, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, List<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, List<Node> children, int startIndexInCollection, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, List<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, List<Node> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, List<Node> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, List<Node> children, int startIndexInCollection, int count, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, List<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, List<Node> children, int startIndexInCollection, int count, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, List<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRange(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRange(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRange(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeLoose(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeLoose(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeLoose(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard(int indexOfReplacement, List<INode> children, int startIndexInCollection, int endIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeConcrete(int indexOfReplacement, List<Node> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard(int indexOfReplacement, List<Node> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete(int indexOfReplacement, List<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete(int indexOfReplacement, List<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard(int indexOfReplacement, List<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard(int indexOfReplacement, List<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLooseWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLooseWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLooseWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcreteWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcreteWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcreteWithConcreteList<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteWithConcreteListAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : List<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}