using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenConcreteForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, Action<Node> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenConcreteForcibly(IEnumerator<INode> children, Func<int, bool> predicate, Action<Node> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenConcreteForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildRemoval,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenWithRangeForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenWithRangeForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenWithRangeForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenWithRangeForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenWithRangeForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenWithRangeForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenWithRangeLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenWithRangeLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenWithRangeLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenWithRangeLooseForcibly(IEnumerator<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenWithRangeLooseForcibly(IEnumerator<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<INode> DetachChildrenWithRangeLooseForcibly(IEnumerator<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal IEnumerator<Node> DetachChildrenWithRangeConcreteForcibly(IEnumerator<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeLooseGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal TEnumerator DetachChildrenWithRangeConcreteGenericEnumeratorForcibly<TEnumerator, TNode>(TEnumerator children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildRemoval, bool discardEnumerator = true)
        where TEnumerator : IEnumerator<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}