using System;
using System.Collections.Generic;
using ReSharperPlugin.Swift.Technology.Graphs.PathfindingAlgorithms;

namespace ReSharperPlugin.Swift.Technology.Graphs;

public interface IReadOnlyWeightedGraph : IReadOnlyGraph
{
    public new ModularVisibilityHashSet<ModularVisibilityHashSet<IReadOnlyWeightedGraphNode>> GetStronglyConnectedComponents();

    public new IReadOnlyWeightedGraph Clone();

    public new IReadOnlyWeightedGraph GetStronglyConnectedComponentSubgraph(Guid node);

    public new IReadOnlyWeightedGraph GetStronglyConnectedComponentSubgraph(IReadOnlyNode node);

    public new IReadOnlyWeightedGraph GetSubgraph(IEnumerable<Guid> nodes);

    public new IReadOnlyWeightedGraph GetSubgraph(IEnumerable<IReadOnlyNode> nodes);

    public new IEnumerator<IReadOnlyWeightedGraphNode> GetNodesEnumerator();

    public new IEnumerator<(IReadOnlyWeightedGraphNode from, IReadOnlyWeightedGraphNode to)> GetEdgesEnumerator();

    public new IEnumerator<IReadOnlyWeightedGraphNode> GetNeighborsEnumerator(Guid node);

    public new IEnumerator<IReadOnlyWeightedGraphNode> GetNeighborsEnumerator(IReadOnlyNode node);

    public new IEnumerator<IReadOnlyWeightedGraphNode> GetStronglyConnectedComponentsEnumerator();

    public new IEnumerator<(IReadOnlyWeightedGraphNode from, IReadOnlyWeightedGraphNode to)> GetStronglyConnectedComponentsEdgesEnumerator();

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(Guid from, Guid to);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(IReadOnlyNode from, Guid to);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(Guid from, IReadOnlyNode to);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(Guid from, Guid to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(Guid from, Guid to);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, Guid to);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(Guid from, IReadOnlyNode to);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(Guid from, Guid to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);
    
    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyWeightedGraphNode> onNodeVisited);

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyWeightedGraphNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyWeightedGraphNode> onNodeVisited);

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyWeightedGraphNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyWeightedGraphNode> onNodeVisited);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyWeightedGraphNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);
}

public interface IReadOnlyWeightedGraph<TValue> : IReadOnlyWeightedGraph, IReadOnlyGraph<TValue>
{
    public new ModularVisibilityHashSet<ModularVisibilityHashSet<IReadOnlyWeightedGraphNode<TValue>>> GetStronglyConnectedComponents();

    public new IReadOnlyWeightedGraph<TValue> Clone();

    public new IReadOnlyWeightedGraph<TValue> GetStronglyConnectedComponentSubgraph(Guid node);

    public new IReadOnlyWeightedGraph<TValue> GetStronglyConnectedComponentSubgraph(IReadOnlyNode node);

    public new IReadOnlyWeightedGraph<TValue> GetSubgraph(IEnumerable<Guid> nodes);

    public new IReadOnlyWeightedGraph<TValue> GetSubgraph(IEnumerable<IReadOnlyNode> nodes);

    public new IEnumerator<IReadOnlyWeightedGraphNode<TValue>> GetNodesEnumerator();

    public new IEnumerator<(IReadOnlyWeightedGraphNode<TValue> from, IReadOnlyWeightedGraphNode<TValue> to)> GetEdgesEnumerator();

    public new IEnumerator<IReadOnlyWeightedGraphNode<TValue>> GetNeighborsEnumerator(Guid node);

    public new IEnumerator<IReadOnlyWeightedGraphNode<TValue>> GetNeighborsEnumerator(IReadOnlyNode node);

    public new IEnumerator<IReadOnlyWeightedGraphNode<TValue>> GetStronglyConnectedComponentsEnumerator();

    public new IEnumerator<(IReadOnlyWeightedGraphNode<TValue> from, IReadOnlyWeightedGraphNode<TValue> to)> GetStronglyConnectedComponentsEdgesEnumerator();

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(Guid from, Guid to);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(Guid from, Guid to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, Guid to);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, Guid to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<IReadOnlyWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);
    
    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyWeightedGraphNode<TValue>> onNodeVisited);

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyWeightedGraphNode<TValue>> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyWeightedGraphNode<TValue>> onNodeVisited);

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyWeightedGraphNode<TValue>> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyWeightedGraphNode<TValue>> onNodeVisited);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyWeightedGraphNode<TValue>> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);
}