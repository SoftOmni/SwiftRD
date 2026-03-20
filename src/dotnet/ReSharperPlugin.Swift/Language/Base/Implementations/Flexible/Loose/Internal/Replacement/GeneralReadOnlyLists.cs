using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public List<INode> ReplaceChildren(int indexOfReplacement, IReadOnlyList<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IReadOnlyList<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IReadOnlyList<Node> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IReadOnlyList<Node> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IReadOnlyList<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IReadOnlyList<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IReadOnlyList<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IReadOnlyList<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLoose<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLoose<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLoose<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard<TList, TNode>(int indexOfReplacement, TList children, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard<TList, TNode>(int indexOfReplacement, TList children, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard<TList, TNode>(int indexOfReplacement, TList children, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenConcrete(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLoose<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLoose<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLoose<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLoose<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLoose<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLoose<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int count, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRange(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRange(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRange(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeLoose(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLoose(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLoose(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard(int indexOfReplacement, IReadOnlyList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard(int indexOfReplacement, IReadOnlyList<Node> children, int startIndexInCollection, int endIndexInCollection,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRange<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRange<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRange<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLoose<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLoose<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLoose<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode, TNode> actionOnAdditionAndRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard<TList, TNode>(int indexOfReplacement, TList children, int startIndexInCollection, int endIndexInCollection,
        Action<TNode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TList : IReadOnlyList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}