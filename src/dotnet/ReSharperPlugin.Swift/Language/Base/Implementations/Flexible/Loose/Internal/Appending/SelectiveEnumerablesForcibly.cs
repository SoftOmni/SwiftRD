using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<INode> children, Func<int, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }


    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration, int count,
        Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration, int count,
        Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int count, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseForcibly(IEnumerable<INode> children, Func<INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseForcibly(IEnumerable<INode> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseForcibly(IEnumerable<INode> children, Func<int, INode, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<INode> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, Func<Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, Func<int, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteForcibly(IEnumerable<Node> children, Func<int, Node, bool> predicate, int startIndexInEnumeration,
        int endIndexInEnumeration, Action<Node> onChildAddition)
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeLooseGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<INode> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : INode
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    internal int AppendChildrenWithRangeConcreteGenericEnumerableForcibly<TEnumerable, TNode>(TEnumerable children, Func<int, TNode, bool> predicate,
        int startIndexInEnumeration, int endIndexInEnumeration, Action<Node> onChildAddition)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }
}