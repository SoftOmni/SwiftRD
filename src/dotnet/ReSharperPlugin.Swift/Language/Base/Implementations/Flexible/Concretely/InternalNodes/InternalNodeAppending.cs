using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.InternalNodes;

public partial class InternalNode
{
    public int AppendChild(INode child)
    {
        throw new NotImplementedException();
    }

    public int AppendChildLoose(INode child)
    {
        throw new NotImplementedException();
    }

    public int AppendChildConcrete(Node child)
    {
        throw new NotImplementedException();
    }

    public int AppendChild<TNode>(TNode child)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildGeneric<TNode>(TNode child)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChild(INode child, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildLoose(INode child, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildConcrete(Node child, Action<Node> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChild<TNode>(TNode child, Action<INode> onChildAttachment)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildGeneric<TNode>(TNode child, Action<TNode> onChildAttachment)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGeneric<TEnumerable, TNode>(TEnumerable children)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenLoose(IEnumerable<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenConcrete(IEnumerable<Node> children, Action<Node> onChildAttachment)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenGeneric<TEnumerable, TNode>(TEnumerable children, Action<TNode> onChildAttachment)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGeneric<TEnumerable, TNode>(TEnumerable children, int startIndexInCollection)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, int startIndexInCollection, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, int startIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, int startIndexInCollection,
        Action<Node> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGeneric<TEnumerable, TNode>(TEnumerable children, int startIndexInCollection,
        Action<TNode> onChildAttachment)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenLoose(IEnumerable<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenConcrete(IEnumerable<Node> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenGeneric<TEnumerable, TNode>(TEnumerable children, int startIndexInCollection, int count)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerable<INode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerable<INode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerable<Node> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGeneric<TEnumerable, TNode>(TEnumerable children, int startIndexInCollection,
        int endIndexInCollection)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IEnumerable<INode> children, int startIndexInCollection, int count,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IEnumerable<INode> children, int startIndexInCollection, int count,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IEnumerable<Node> children, int startIndexInCollection, int count,
        Action<Node> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGeneric<TEnumerable, TNode>(TEnumerable children, int startIndexInCollection, int count,
        Action<TNode> onChildAttachment)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IEnumerable<INode> children, int startIndexInCollection,
        int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeLoose(IEnumerable<INode> children, int startIndexInCollection,
        int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeConcrete(IEnumerable<Node> children, int startIndexInCollection,
        int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRangeGeneric<TEnumerable, TNode>(TEnumerable children, int startIndexInCollection,
        int endIndexInCollection,
        Action<TNode> onChildAttachment)
        where TEnumerable : IEnumerable<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IList<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IList<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IList<Node> children)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericList<TList, TNode>(TList children)
        where TList : IList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IList<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenLoose(IList<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenConcrete(IList<Node> children, Action<Node> onChildAttachment)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenGenericList<TList, TNode>(TList children, Action<TNode> onChildAttachment)
        where TList : IList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IList<Node> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericList<TList, TNode>(TList children, int startIndexInCollection)
        where TList : IList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IList<INode> children, int startIndexInCollection, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenLoose(IList<INode> children, int startIndexInCollection, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenConcrete(IList<Node> children, int startIndexInCollection, Action<Node> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericList<TList, TNode>(TList children, int startIndexInCollection, Action<TNode> onChildAttachment)
        where TList : IList<TNode> where TNode : Node
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenLoose(IList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }


    public int AppendChildrenConcrete(IList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenGenericList(IList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(IList<INode> children, int startIndexInCollection, int count,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(IList<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, int startIndexInCollection, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren(List<INode> children, int startIndexInCollection, int count,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange(List<INode> children, int startIndexInCollection, int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TList, TListElements>(TList children)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TList, TListElements>(TList children, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection,
        Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildren<TList, TListElements>(TList children, int startIndexInCollection, int count,
        Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenWithRange<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection,
        Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildForcibly(INode child)
    {
        throw new NotImplementedException();
    }

    public int AppendChildForcibly(INode child, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(IEnumerable<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(IEnumerable<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForciblyWithRange(IEnumerable<INode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(IEnumerable<INode> children, int startIndexInCollection, int count,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForciblyWithRange(IEnumerable<INode> children, int startIndexInCollection,
        int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(IList<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(IList<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(IList<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(IList<INode> children, int startIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(IList<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForciblyWithRange(IList<INode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(IList<INode> children, int startIndexInCollection, int count,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForciblyWithRange(IList<INode> children, int startIndexInCollection,
        int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(List<INode> children)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(List<INode> children, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(List<INode> children, int startIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(List<INode> children, int startIndexInCollection, Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(List<INode> children, int startIndexInCollection, int count)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForciblyWithRange(List<INode> children, int startIndexInCollection,
        int endIndexInCollection)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly(List<INode> children, int startIndexInCollection, int count,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForciblyWithRange(List<INode> children, int startIndexInCollection,
        int endIndexInCollection,
        Action<INode> onChildAttachment)
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly<TList, TListElements>(TList children)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly<TList, TListElements>(TList children, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection,
        Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, int count)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForciblyWithRange<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForcibly<TList, TListElements>(TList children, int startIndexInCollection, int count,
        Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }

    public int AppendChildrenForciblyWithRange<TList, TListElements>(TList children, int startIndexInCollection,
        int endIndexInCollection, Action<INode> onChildAttachment)
        where TList : IList<TListElements> where TListElements : INode
    {
        throw new NotImplementedException();
    }
}