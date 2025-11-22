using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Technology.Graphs;

public interface IWeightedGraphNode : IReadOnlyWeightedGraphNode, INode
{
    public new IWeightedGraph Graph { get; }
    
    public new IReadOnlyList<IWeightedGraphNode> GetOutgoingEdges();

    public new IReadOnlyList<IWeightedGraphNode> GetIncomingEdges();
}

public interface IWeightedGraphNode<TValue> : IReadOnlyWeightedGraphNode<TValue>, IWeightedGraphNode, INode<TValue>
{
    public new IWeightedGraph<TValue> Graph { get; }
    
    public new IReadOnlyList<IWeightedGraphNode<TValue>> GetOutgoingEdges();

    public new IReadOnlyList<IWeightedGraphNode<TValue>> GetIncomingEdges();
}