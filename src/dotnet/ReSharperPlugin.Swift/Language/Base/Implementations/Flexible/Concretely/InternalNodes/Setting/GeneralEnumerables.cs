using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public List<INode> SetChildren(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(IEnumerable<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerable<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IEnumerable<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerable<INode> children, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerable<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IEnumerable<Node> children)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerable<Node> children)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenConcrete(IEnumerable<Node> children, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenConcrete(IEnumerable<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerable<Node> children, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerable<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public List<INode> SetChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public List<Node> SetChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IEnumerable<Node> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerable<Node> children, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IEnumerable<Node> children, int startIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IEnumerable<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerable<Node> children, int startIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerable<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IEnumerable<Node> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerable<Node> children, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerable<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRange(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeLoose(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeLoose(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeLoose(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard(IEnumerable<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete(IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard(IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete(IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete(IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard(IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard(IEnumerable<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteGenericEnumerableAndDiscard<TEnumerable, TNode>(TEnumerable children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}