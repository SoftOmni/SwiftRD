using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public List<INode> ReplaceChildren(int indexOfReplacement, IEnumerator<INode> children, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerator<INode> children, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, IEnumerator<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerator<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }


    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerator<INode> children, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerator<INode> children, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerator<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerator<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }


    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerator<Node> children, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerator<Node> children, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerator<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerator<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerator<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerator<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public List<Node> ReplaceChildrenLooseGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public List<Node> ReplaceChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<Node, Node?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<Node, Node?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLoose(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLoose(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildren(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLoose(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLoose(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int count, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int count, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node, Node?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node, Node?> actionOnAdditionAndRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenLooseGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRange(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRange(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRange(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLoose(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLoose(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLoose(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard(int indexOfReplacement, IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard(int indexOfReplacement, IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(int indexOfReplacement, TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true, bool extend = false)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}