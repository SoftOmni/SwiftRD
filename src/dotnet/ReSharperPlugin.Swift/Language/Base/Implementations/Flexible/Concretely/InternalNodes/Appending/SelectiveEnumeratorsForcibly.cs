using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, Action<Node> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<INode> children, Func<int, bool> predicate, Action<Node> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildAddition,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}