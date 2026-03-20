using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public int AppendChildren(IEnumerator<INode> children, Func<INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<INode> children, Func<INode, bool> predicate, Action<Node> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<INode> children, Func<int, bool> predicate, Action<Node> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, Action<INode> onChildAddition,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, Action<INode> onChildAddition,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerator<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}