using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public List<INode> SetChildren(IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(IEnumerator<INode> children, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildren(IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerator<INode> children, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }


    public List<INode> SetChildrenLoose(IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerator<INode> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IEnumerator<INode> children, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerator<INode> children, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerator<INode> children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }


    public List<Node> SetChildrenConcrete(IEnumerator<Node> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerator<Node> children, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenConcrete(IEnumerator<Node> children, Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenConcrete(IEnumerator<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerator<Node> children, Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerator<Node> children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public List<Node> SetChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public List<Node> SetChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Action<Node, Node> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, Action<Node, Node> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren(IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerator<Node> children, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerator<Node> children, int startIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerator<Node> children, int startIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren(IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildren(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLoose(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode, INode> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, int count, Action<INode> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerator<Node> children, int startIndexInEnumeration, int count, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node, Node> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node, Node> actionOnAdditionAndRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteAndDiscard(IEnumerator<Node> children, int startIndexInEnumeration, int count, Action<Node> actionOnAddition, Action<Node> actionOnRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration, int count,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRange(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLoose(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLoose(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLoose(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseAndDiscard(IEnumerator<INode> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcrete(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteAndDiscard(IEnumerator<Node> children, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode, INode> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeLooseGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node, Node> actionOnAdditionAndRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildrenWithRangeConcreteGenericEnumeratorAndDiscard<TEnumerator, TNode>(TEnumerator children, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> actionOnAddition, Action<Node> actionOnRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}