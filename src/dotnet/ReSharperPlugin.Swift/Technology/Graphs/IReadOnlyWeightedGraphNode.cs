using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Technology.Graphs;

public interface IReadOnlyWeightedGraphNode : IReadOnlyNode
{
    public new IReadOnlyWeightedGraph Graph { get; }
    
    public double GetWeightOfEdgeTo(IReadOnlyNode targetNode);
    
    public double GetWeightOfEdgeFrom(IReadOnlyNode sourceNode);
    
    public new IReadOnlyList<IReadOnlyWeightedGraphNode> GetOutgoingEdges();
    
    public new IReadOnlyList<IReadOnlyWeightedGraphNode> GetIncomingEdges();
}

public interface IReadOnlyWeightedGraphNode<TValue> : IReadOnlyNode<TValue>, IReadOnlyWeightedGraphNode
{
    public new IReadOnlyWeightedGraph<TValue> Graph { get; }
    
    public new IReadOnlyList<IReadOnlyWeightedGraphNode<TValue>> GetOutgoingEdges();
    
    public new IReadOnlyList<IReadOnlyWeightedGraphNode<TValue>> GetIncomingEdges();
}