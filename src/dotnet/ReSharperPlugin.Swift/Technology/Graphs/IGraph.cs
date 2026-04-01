using System;
using System.Collections.Generic;
using SoftOmni.SwiftRd.Technology.Graphs.PathfindingAlgorithms;

namespace SoftOmni.SwiftRd.Technology.Graphs;

public interface IGraph : IReadOnlyGraph
{
    public void AddNode(INode node);
    
    public void AddEdge(INode sourceNode, INode targetNode);
    
    public void RemoveNode(INode node);
    
    public void RemoveEdge(INode sourceNode, INode targetNode);
    
    public new ModularVisibilityHashSet<INode> GetNeighbors(Guid node);

    public new ModularVisibilityHashSet<ModularVisibilityHashSet<INode>> GetStronglyConnectedComponents();

    public new IGraph Clone();

    public new IGraph GetStronglyConnectedComponentSubgraph(Guid node);

    public new IGraph GetStronglyConnectedComponentSubgraph(IReadOnlyNode node);

    public new IGraph GetSubgraph(IEnumerable<Guid> nodes);

    public new IGraph GetSubgraph(IEnumerable<IReadOnlyNode> nodes);

    public new IEnumerator<INode> GetNodesEnumerator();

    public new IEnumerator<(INode from, INode to)> GetEdgesEnumerator();

    public new IEnumerator<INode> GetNeighborsEnumerator(Guid node);

    public new IEnumerator<INode> GetNeighborsEnumerator(IReadOnlyNode node);

    public new IEnumerator<INode> GetStronglyConnectedComponentsEnumerator();

    public new IEnumerator<(INode from, INode to)> GetStronglyConnectedComponentsEdgesEnumerator();

    public new List<INode> GetPathBetween(Guid from, Guid to);

    public new List<INode> GetPathBetween(IReadOnlyNode from, Guid to);

    public new List<INode> GetPathBetween(Guid from, IReadOnlyNode to);

    public new List<INode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<INode> GetPathBetween(Guid from, Guid to, int maxDepth);

    public new List<INode> GetPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<INode> GetPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<INode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<INode> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm);

    public new List<INode> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm);

    public new List<INode> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public new List<INode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public new List<INode> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm, int maxDepth);

    public new List<INode> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<INode> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<INode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<INode> GetShortestPathBetween(Guid from, Guid to);

    public new List<INode> GetShortestPathBetween(IReadOnlyNode from, Guid to);

    public new List<INode> GetShortestPathBetween(Guid from, IReadOnlyNode to);

    public new List<INode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<INode> GetShortestPathBetween(Guid from, Guid to, int maxDepth);

    public new List<INode> GetShortestPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<INode> GetShortestPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<INode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<INode> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm);

    public new List<INode> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<INode> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<INode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<INode> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<INode> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<INode> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<INode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);
    
    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<INode> onNodeVisited);

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<INode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(Guid startNode, Action<INode> onNodeVisited);

    public void DepthFirstSearch(Guid startNode, Action<INode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<INode> onNodeVisited);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<INode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);
}

public interface IGraph<TValue> : IReadOnlyGraph<TValue>, IGraph
{
    public new ModularVisibilityHashSet<INode<TValue>> GetNeighbors(Guid node);

    public new ModularVisibilityHashSet<ModularVisibilityHashSet<INode<TValue>>> GetStronglyConnectedComponents();

    public new IGraph<TValue> Clone();

    public new IGraph<TValue> GetStronglyConnectedComponentSubgraph(Guid node);

    public new IGraph<TValue> GetStronglyConnectedComponentSubgraph(IReadOnlyNode node);

    public new IGraph<TValue> GetSubgraph(IEnumerable<Guid> nodes);

    public new IGraph<TValue> GetSubgraph(IEnumerable<IReadOnlyNode> nodes);

    public new IEnumerator<INode<TValue>> GetNodesEnumerator();

    public new IEnumerator<(INode<TValue> from, INode<TValue> to)> GetEdgesEnumerator();

    public new IEnumerator<INode<TValue>> GetNeighborsEnumerator(Guid node);

    public new IEnumerator<INode<TValue>> GetNeighborsEnumerator(IReadOnlyNode node);

    public new IEnumerator<INode<TValue>> GetStronglyConnectedComponentsEnumerator();

    public new IEnumerator<(INode<TValue> from, INode<TValue> to)> GetStronglyConnectedComponentsEdgesEnumerator();

    public new List<INode<TValue>> GetPathBetween(Guid from, Guid to);

    public new List<INode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to);

    public new List<INode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to);

    public new List<INode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<INode<TValue>> GetPathBetween(Guid from, Guid to, int maxDepth);

    public new List<INode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<INode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<INode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<INode<TValue>> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm);

    public new List<INode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm);

    public new List<INode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public new List<INode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm);

    public new List<INode<TValue>> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm, int maxDepth);

    public new List<INode<TValue>> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<INode<TValue>> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<INode<TValue>> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<INode<TValue>> GetShortestPathBetween(Guid from, Guid to);

    public new List<INode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to);

    public new List<INode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to);

    public new List<INode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to);

    public new List<INode<TValue>> GetShortestPathBetween(Guid from, Guid to, int maxDepth);

    public new List<INode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to, int maxDepth);

    public new List<INode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to, int maxDepth);

    public new List<INode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth);

    public new List<INode<TValue>> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm);

    public new List<INode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<INode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<INode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm);

    public new List<INode<TValue>> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm,
        int maxDepth);

    public new List<INode<TValue>> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<INode<TValue>> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);

    public new List<INode<TValue>> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth);
    
    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<INode<TValue>> onNodeVisited);

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<INode<TValue>> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(Guid startNode, Action<INode<TValue>> onNodeVisited);

    public void DepthFirstSearch(Guid startNode, Action<INode<TValue>> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<INode<TValue>> onNodeVisited);

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<INode<TValue>> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference);
}