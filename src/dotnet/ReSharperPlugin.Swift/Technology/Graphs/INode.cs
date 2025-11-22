using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Technology.Graphs;

public interface INode : IReadOnlyNode
{
    public new IGraph Graph { get; }
    
    public void AddOutgoingEdgeTo(INode targetNode);
    
    public void AddIncomingEdgeFrom(INode sourceNode);
    
    public void RemoveOutgoingEdgeTo(INode targetNode);
    
    public void RemoveIncomingEdgeFrom(INode sourceNode);

    public new IReadOnlyList<INode> GetOutgoingEdges();

    public new IReadOnlyList<INode> GetIncomingEdges();
}


public interface INode<TValue> : IReadOnlyNode<TValue>, INode
{
    public new IGraph<TValue> Graph { get; }
    
    public new IReadOnlyList<INode<TValue>> GetOutgoingEdges();

    public new IReadOnlyList<INode<TValue>> GetIncomingEdges();
}