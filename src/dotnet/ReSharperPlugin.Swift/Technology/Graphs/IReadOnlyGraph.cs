using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Technology.Graphs.PathfindingAlgorithms;

namespace ReSharperPlugin.Swift.Technology.Graphs;

public interface IReadOnlyGraph
{
    public int NodeCount { get; }

    public int EdgeCount { get; }

    public bool ContainsNode(Guid node);

    public bool ContainsNode(IReadOnlyNode node);

    public bool ContainsEdge(Guid from, Guid to);

    public bool ContainsEdge(IReadOnlyNode from, Guid to);

    public bool ContainsEdge(Guid from, IReadOnlyNode to);

    public bool ContainsEdge(IReadOnlyNode from, IReadOnlyNode to);

    public bool IsDirected { get; }

    public bool IsWeighted { get; }
    
    public IReadOnlyList<IReadOnlyNode> GetNodes();

    public ModularVisibilityHashSet<IReadOnlyNode> GetNeighbors(Guid node);

    public ModularVisibilityHashSet<ModularVisibilityHashSet<IReadOnlyNode>> GetStronglyConnectedComponents();

    public IReadOnlyGraph Clone();

    public IReadOnlyGraph GetStronglyConnectedComponentSubgraph(Guid node);

    public IReadOnlyGraph GetStronglyConnectedComponentSubgraph(IReadOnlyNode node);

    public IReadOnlyGraph GetSubgraph(IEnumerable<Guid> nodes);

    public IReadOnlyGraph GetSubgraph(IEnumerable<IReadOnlyNode> nodes);

    public IEnumerator<IReadOnlyNode> GetNodesEnumerator();

    public IEnumerator<(IReadOnlyNode from, IReadOnlyNode to)> GetEdgesEnumerator();

    public IEnumerator<IReadOnlyNode> GetNeighborsEnumerator(Guid node);

    public IEnumerator<IReadOnlyNode> GetNeighborsEnumerator(IReadOnlyNode node);

    public IEnumerator<IReadOnlyNode> GetStronglyConnectedComponentsEnumerator();

    public IEnumerator<(IReadOnlyNode from, IReadOnlyNode to)> GetStronglyConnectedComponentsEdgesEnumerator();

    public List<IReadOnlyNode> GetPathBetween(Guid from, Guid to);

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, Guid to);

    public List<IReadOnlyNode> GetPathBetween(Guid from, IReadOnlyNode to);

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public List<IReadOnlyNode> GetPathBetween(Guid from, Guid to, int maxDepth);

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public List<IReadOnlyNode> GetPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public List<IReadOnlyNode> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm);

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm);

    public List<IReadOnlyNode> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public List<IReadOnlyNode> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm, int maxDepth);

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public List<IReadOnlyNode> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, Guid to);

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, Guid to);

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, IReadOnlyNode to);

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, Guid to, int maxDepth);

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm);

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm);

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm,
        int maxDepth);

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public void BreadthFirstSearch(Guid node, Action<IReadOnlyNode> onNodeVisited);

    public void BreadthFirstSearch(Guid startNode, Action<IReadOnlyNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode> onNodeVisited);

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyNode> onNodeVisited);

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode> onNodeVisited);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);
}

public interface IReadOnlyGraph<TValue> : IReadOnlyGraph, IReadOnlyCollection<TValue>
{
    public bool ContainsNode(TValue node);

    public bool ContainsEdge(TValue from, TValue to);

    public new IReadOnlyGraph<TValue> Clone();

    public new IReadOnlyGraph<TValue> GetStronglyConnectedComponentSubgraph(Guid node);

    public new IReadOnlyGraph<TValue> GetStronglyConnectedComponentSubgraph(IReadOnlyNode node);

    public new IReadOnlyGraph<TValue> GetSubgraph(IEnumerable<Guid> nodes);

    public new IReadOnlyGraph<TValue> GetSubgraph(IEnumerable<IReadOnlyNode> nodes);

    public new IEnumerator<IReadOnlyNode<TValue>> GetNodesEnumerator();

    public new IEnumerator<(IReadOnlyNode<TValue> from, IReadOnlyNode<TValue> to)> GetEdgesEnumerator();

    public new IEnumerator<IReadOnlyNode<TValue>> GetNeighborsEnumerator(Guid node);

    public new IEnumerator<IReadOnlyNode<TValue>> GetNeighborsEnumerator(IReadOnlyNode node);

    public new IEnumerator<IReadOnlyNode<TValue>> GetStronglyConnectedComponentsEnumerator();

    public new IEnumerator<(IReadOnlyNode<TValue> from, IReadOnlyNode<TValue> to)>
        GetStronglyConnectedComponentsEdgesEnumerator();

    public new List<IReadOnlyNode<TValue>> GetPathBetween(Guid from, Guid to);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(Guid from, Guid to, int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        PathfindingAlgorithm algorithm);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        PathfindingAlgorithm algorithm, int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(Guid from, Guid to);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(Guid from, Guid to, int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(Guid from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(Guid from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<IReadOnlyNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode<TValue>> onNodeVisited);

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode<TValue>> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyNode<TValue>> onNodeVisited);

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyNode<TValue>> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode<TValue>> onNodeVisited);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode<TValue>> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);
}