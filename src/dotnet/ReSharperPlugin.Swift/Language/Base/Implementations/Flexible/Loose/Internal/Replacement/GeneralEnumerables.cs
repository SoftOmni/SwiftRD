using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public List<INode> ReplaceChildren(int indexOfReplacement, IEnumerable<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerable<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, IEnumerable<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerable<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerable<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerable<INode> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerable<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerable<INode> children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerable<Node> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerable<Node> children, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerable<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerable<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerable<Node> children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerable<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public List<INode> ReplaceChildrenLooseGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLooseGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLooseGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public List<Node> ReplaceChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLooseGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLooseGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLooseGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildren(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLoose(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int count, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenConcrete(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteAndDiscard(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLooseGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLooseGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenLooseGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenConcreteGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRange(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRange(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRange(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeLoose(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeLoose(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeLoose(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseAndDiscard(int indexOfReplacement, IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcrete(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteAndDiscard(int indexOfReplacement, IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> ReplaceChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> ReplaceChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node?> actionOnAdditionAndRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void ReplaceChildrenWithRangeConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(int indexOfReplacement, TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool extend = false)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}