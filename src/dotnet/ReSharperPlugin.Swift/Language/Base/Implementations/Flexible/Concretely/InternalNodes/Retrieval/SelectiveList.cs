using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.InternalNodes;

public partial class InternalNode
{
    public List<INode> GetSelectiveNodesAsList(Func<INode, bool> predicate)
        => GetSelectiveLooseNodesAsList(predicate);

    public List<INode> GetSelectiveNodesAsList(Func<INode, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsList(predicate, onChildRetrieval);
    
    public List<INode> GetSelectiveNodesAsList(Func<int, bool> predicate)
        => GetSelectiveLooseNodesAsList(predicate);

    public List<INode> GetSelectiveNodesAsList(Func<int, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsList(predicate, onChildRetrieval);

    public List<INode> GetSelectiveNodesAsList(Func<INode, int, bool> predicate)
        => GetSelectiveLooseNodesAsList(predicate);

    public List<INode> GetSelectiveNodesAsList(Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsList(predicate, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsList(Func<INode, bool> predicate)
        => GetSelectiveLooseNodesAsGenericListType(predicate);

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsList(Func<INode, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsList(Func<int, bool> predicate)
        => GetSelectiveLooseNodesAsGenericListType(predicate);

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsList(Func<int, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsList(Func<INode, int, bool> predicate)
        => GetSelectiveLooseNodesAsGenericListType(predicate);

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsList(Func<INode, int, bool> predicate, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, onChildRetrieval);

    public List<Node> GetSelectiveConcreteNodesAsList(Func<Node, bool> predicate)
        => GetSelectiveConcreteNodesAsGenericListType(predicate);

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsList(Func<Node, bool> predicate, Action<Node> onChildRetrieval)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, onChildRetrieval);

    public List<Node> GetSelectiveConcreteNodesAsList(Func<int, bool> predicate)
        => GetSelectiveConcreteNodesAsGenericListType(predicate);

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsList(Func<int, bool> predicate, Action<Node> onChildRetrieval)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, onChildRetrieval);

    public List<Node> GetSelectiveConcreteNodesAsList(Func<Node, int, bool> predicate)
        => GetSelectiveConcreteNodesAsGenericListType(predicate);

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsList(Func<Node, int, bool> predicate, Action<Node> onChildRetrieval)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, onChildRetrieval);

    public List<INode> GetSelectiveNodesAsList(Func<INode, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesAsList(predicate, startIndex);

    public List<INode> GetSelectiveNodesAsList(Func<INode, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsList(predicate, startIndex, onChildRetrieval);

    public List<INode> GetSelectiveNodesAsList(Func<int, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesAsList(predicate, startIndex);

    public List<INode> GetSelectiveNodesAsList(Func<int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsList(predicate, startIndex, onChildRetrieval);

    public List<INode> GetSelectiveNodesAsList(Func<INode, int, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesAsList(predicate, startIndex);

    public List<INode> GetSelectiveNodesAsList(Func<INode, int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsList(predicate, startIndex, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsList(Func<INode, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex);

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsList(Func<INode, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, onChildRetrieval);
    
    public List<INode> GetSelectiveLooseNodesAsList(Func<int, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex);

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsList(Func<int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, onChildRetrieval);
    
    public List<INode> GetSelectiveLooseNodesAsList(Func<INode, int, bool> predicate, int startIndex)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex);
    
    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsList(Func<INode, int, bool> predicate, int startIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, onChildRetrieval);

    public List<Node> GetSelectiveConcreteNodesAsList(Func<Node, bool> predicate, int startIndex)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, startIndex);

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsList(Func<Node, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, startIndex, onChildRetrieval);

    public List<Node> GetSelectiveConcreteNodesAsList(Func<int, bool> predicate, int startIndex)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, startIndex);

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsList(Func<int, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, startIndex, onChildRetrieval);

    public List<Node> GetSelectiveConcreteNodesAsList(Func<Node, int, bool> predicate, int startIndex)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, startIndex);

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsList(Func<Node, int, bool> predicate, int startIndex, Action<Node> onChildRetrieval)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, startIndex, onChildRetrieval);

    public List<INode> GetSelectiveNodesAsList(Func<INode, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesAsList(predicate, startIndex, count);

    public List<INode> GetSelectiveNodesAsList(Func<INode, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsList(predicate, startIndex, count, onChildRetrieval);

    public List<INode> GetSelectiveNodesAsList(Func<int, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesAsList(predicate, startIndex, count);

    public List<INode> GetSelectiveNodesAsList(Func<int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsList(predicate, startIndex, count, onChildRetrieval);

    public List<INode> GetSelectiveNodesAsList(Func<INode, int, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesAsList(predicate, startIndex, count);

    public List<INode> GetSelectiveNodesAsList(Func<INode, int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsList(predicate, startIndex, count, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsList(Func<INode, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, count);

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsList(Func<INode, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, count, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsList(Func<int, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, count);

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsList(Func<int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, count, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsList(Func<INode, int, bool> predicate, int startIndex, int count)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, count);

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsList(Func<INode, int, bool> predicate, int startIndex, int count, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListType(predicate, startIndex, count, onChildRetrieval);

    public List<Node> GetSelectiveConcreteNodesAsList(Func<Node, bool> predicate, int startIndex, int count)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, startIndex, count);

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsList(Func<Node, bool> predicate, int startIndex, int count, Action<Node> onChildRetrieval)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, startIndex, count, onChildRetrieval);

    public List<Node> GetSelectiveConcreteNodesAsList(Func<int, bool> predicate, int startIndex, int count)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, startIndex, count);

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsList(Func<int, bool> predicate, int startIndex, int count, Action<Node> onChildRetrieval)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, startIndex, count, onChildRetrieval);

    public List<Node> GetSelectiveConcreteNodesAsList(Func<Node, int, bool> predicate, int startIndex, int count)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, startIndex, count);

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsList(Func<Node, int, bool> predicate, int startIndex, int count, Action<Node> onChildRetrieval)
        => GetSelectiveConcreteNodesAsGenericListType(predicate, startIndex, count, onChildRetrieval);

    public List<INode> GetSelectiveNodesAsListOverRange(Func<INode, bool> predicate, int startIndex, int endIndex)
        => GetSelectiveLooseNodesAsListOverRange(predicate, startIndex, endIndex);

    public List<INode> GetSelectiveNodesAsListOverRange(Func<INode, bool> predicate, int startIndex, int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsListOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public List<INode> GetSelectiveNodesAsListOverRange(Func<int, bool> predicate, int startIndex, int endIndex)
        => GetSelectiveLooseNodesAsListOverRange(predicate, startIndex, endIndex);

    public List<INode> GetSelectiveNodesAsListOverRange(Func<int, bool> predicate, int startIndex, int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsListOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public List<INode> GetSelectiveNodesAsListOverRange(Func<INode, int, bool> predicate, int startIndex, int endIndex)
        => GetSelectiveLooseNodesAsListOverRange(predicate, startIndex, endIndex);

    public List<INode> GetSelectiveNodesAsListOverRange(Func<INode, int, bool> predicate, int startIndex, int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsListOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsListOverRange(Func<INode, bool> predicate, int startIndex, int endIndex)
        => GetSelectiveLooseNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex);

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsListOverRange(Func<INode, bool> predicate, int startIndex, int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsListOverRange(Func<int, bool> predicate, int startIndex, int endIndex)
        => GetSelectiveLooseNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex);

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsListOverRange(Func<int, bool> predicate, int startIndex, int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public List<INode> GetSelectiveLooseNodesAsListOverRange(Func<INode, int, bool> predicate, int startIndex, int endIndex)
        => GetSelectiveLooseNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex);

    public ListWithLooseNodesWithAction GetSelectiveLooseNodesAsListOverRange(Func<INode, int, bool> predicate, int startIndex, int endIndex, Action<INode> onChildRetrieval)
        => GetSelectiveLooseNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public List<Node> GetSelectiveConcreteNodesAsListOverRange(Func<Node, bool> predicate, int startIndex, int endIndex)
        => GetSelectiveConcreteNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex);

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsListOverRange(Func<Node, bool> predicate, int startIndex, int endIndex, Action<Node> onChildRetrieval)
        => GetSelectiveConcreteNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public List<Node> GetSelectiveConcreteNodesAsListOverRange(Func<int, bool> predicate, int startIndex, int endIndex)
        => GetSelectiveConcreteNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex);

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsListOverRange(Func<int, bool> predicate, int startIndex, int endIndex, Action<Node> onChildRetrieval)
        => GetSelectiveConcreteNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex, onChildRetrieval);

    public List<Node> GetSelectiveConcreteNodesAsListOverRange(Func<Node, int, bool> predicate, int startIndex, int endIndex)
        => GetSelectiveConcreteNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex);

    public ListWithConcreteNodesWithAction GetSelectiveConcreteNodesAsListOverRange(Func<Node, int, bool> predicate, int startIndex, int endIndex, Action<Node> onChildRetrieval)
        => GetSelectiveConcreteNodesAsGenericListTypeOverRange(predicate, startIndex, endIndex, onChildRetrieval);
}
