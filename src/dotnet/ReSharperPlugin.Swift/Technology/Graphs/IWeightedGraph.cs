using System;
using System.Collections.Generic;
using SoftOmni.SwiftRd.Technology.Graphs.PathfindingAlgorithms;

namespace SoftOmni.SwiftRd.Technology.Graphs;

public interface IWeightedGraph : IReadOnlyWeightedGraph, IGraph
{
    public new ModularVisibilityHashSet<ModularVisibilityHashSet<IWeightedGraphNode>> GetStronglyConnectedComponents();

    public new IWeightedGraph Clone();

    public new IWeightedGraph GetStronglyConnectedComponentSubgraph(Guid node);

    public new IWeightedGraph GetStronglyConnectedComponentSubgraph(IReadOnlyNode node);

    public new IWeightedGraph GetSubgraph(IEnumerable<Guid> nodes);

    public new IWeightedGraph GetSubgraph(IEnumerable<IReadOnlyNode> nodes);

    public new IEnumerator<IWeightedGraphNode> GetNodesEnumerator();

    public new IEnumerator<(IWeightedGraphNode from, IWeightedGraphNode to)> GetEdgesEnumerator();

    public new IEnumerator<IWeightedGraphNode> GetNeighborsEnumerator(Guid node);

    public new IEnumerator<IWeightedGraphNode> GetNeighborsEnumerator(IReadOnlyNode node);

    public new IEnumerator<IWeightedGraphNode> GetStronglyConnectedComponentsEnumerator();

    public new IEnumerator<(IWeightedGraphNode from, IWeightedGraphNode to)> GetStronglyConnectedComponentsEdgesEnumerator();

    public new List<IWeightedGraphNode> GetPathBetween(Guid from, Guid to);

    public new List<IWeightedGraphNode> GetPathBetween(IReadOnlyNode from, Guid to);

    public new List<IWeightedGraphNode> GetPathBetween(Guid from, IReadOnlyNode to);

    public new List<IWeightedGraphNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<IWeightedGraphNode> GetPathBetween(Guid from, Guid to, int maxDepth);

    public new List<IWeightedGraphNode> GetPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<IWeightedGraphNode> GetPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<IWeightedGraphNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<IWeightedGraphNode> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm, int maxDepth);

    public new List<IWeightedGraphNode> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IWeightedGraphNode> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IWeightedGraphNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IWeightedGraphNode> GetShortestPathBetween(Guid from, Guid to);

    public new List<IWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, Guid to);

    public new List<IWeightedGraphNode> GetShortestPathBetween(Guid from, IReadOnlyNode to);

    public new List<IWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<IWeightedGraphNode> GetShortestPathBetween(Guid from, Guid to, int maxDepth);

    public new List<IWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<IWeightedGraphNode> GetShortestPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<IWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<IWeightedGraphNode> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<IWeightedGraphNode> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<IWeightedGraphNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);
    
    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IWeightedGraphNode> onNodeVisited);

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IWeightedGraphNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(Guid startNode, Action<IWeightedGraphNode> onNodeVisited);

    public void DepthFirstSearch(Guid startNode, Action<IWeightedGraphNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IWeightedGraphNode> onNodeVisited);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IWeightedGraphNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);
}

public interface IWeightedGraph<TValue> : IReadOnlyWeightedGraph<TValue>, IWeightedGraph, IGraph<TValue>
{
    public new ModularVisibilityHashSet<ModularVisibilityHashSet<IWeightedGraphNode<TValue>>> GetStronglyConnectedComponents();

    public new IWeightedGraph<TValue> Clone();

    public new IWeightedGraph<TValue> GetStronglyConnectedComponentSubgraph(Guid node);

    public new IWeightedGraph<TValue> GetStronglyConnectedComponentSubgraph(IReadOnlyNode node);

    public new IWeightedGraph<TValue> GetSubgraph(IEnumerable<Guid> nodes);

    public new IWeightedGraph<TValue> GetSubgraph(IEnumerable<IReadOnlyNode> nodes);

    public new IEnumerator<IWeightedGraphNode<TValue>> GetNodesEnumerator();

    public new IEnumerator<(IWeightedGraphNode<TValue> from, IWeightedGraphNode<TValue> to)> GetEdgesEnumerator();

    public new IEnumerator<IWeightedGraphNode<TValue>> GetNeighborsEnumerator(Guid node);

    public new IEnumerator<IWeightedGraphNode<TValue>> GetNeighborsEnumerator(IReadOnlyNode node);

    public new IEnumerator<IWeightedGraphNode<TValue>> GetStronglyConnectedComponentsEnumerator();

    public new IEnumerator<(IWeightedGraphNode<TValue> from, IWeightedGraphNode<TValue> to)> GetStronglyConnectedComponentsEdgesEnumerator();

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(Guid from, Guid to);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(Guid from, Guid to, int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm, int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, Guid to);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, Guid to, int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<IWeightedGraphNode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);
    
    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IWeightedGraphNode<TValue>> onNodeVisited);

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IWeightedGraphNode<TValue>> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(Guid startNode, Action<IWeightedGraphNode<TValue>> onNodeVisited);

    public void DepthFirstSearch(Guid startNode, Action<IWeightedGraphNode<TValue>> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IWeightedGraphNode<TValue>> onNodeVisited);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IWeightedGraphNode<TValue>> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);
}