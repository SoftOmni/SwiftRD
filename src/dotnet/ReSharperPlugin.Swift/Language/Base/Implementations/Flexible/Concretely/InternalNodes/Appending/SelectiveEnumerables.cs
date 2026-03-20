using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public int AppendChildren(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<INode> children, Func<INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<INode> children, Func<int, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate, int startIndexInEnumeration,
        int count, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int endIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLooseGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcreteGenericEnumerable<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}