using System;
using System.Collections.Generic;

namespace ReSharperPlugin.Swift.Technology.Graphs;

/// <summary>
/// 
/// </summary>
public interface IReadOnlyNode
{
    public IReadOnlyGraph Graph { get; }
    
    public Guid Id { get; }
    
    public int Index { get; }
    
    public IReadOnlyList<IReadOnlyNode> GetOutgoingEdges();
    
    public IReadOnlyList<IReadOnlyNode> GetIncomingEdges();
    
    public bool ContainsEdgeTo(Guid node);
    
    public bool ContainsEdgeTo(IReadOnlyNode node);
    
    public bool ContainsEdgeFrom(Guid node);
    
    public bool ContainsEdgeFrom(IReadOnlyNode node);
}

public interface IReadOnlyNode<TValue> : IReadOnlyNode
{
    public new IReadOnlyGraph<TValue> Graph { get; }
    
    public TValue Value { get; }
    
    public new IReadOnlyList<IReadOnlyNode<TValue>> GetOutgoingEdges();
    
    public new IReadOnlyList<IReadOnlyNode<TValue>> GetIncomingEdges();
}