/*using System;
using System.Collections.Generic;
using System.Linq;
using JetBrains.Util;
using SoftOmni.SwiftRd.Technology.Graphs.PathfindingAlgorithms;

namespace SoftOmni.SwiftRd.Technology.Graphs.Implementations;

public class UndirectedReadOnlyAdjacencyMatrix : IReadOnlyGraph
{
    private readonly List<(List<Node> row, Node node)> _adjacencyMatrix;

    public UndirectedReadOnlyAdjacencyMatrix(IEnumerable<object> nodes, IEnumerable<(object from, object to)> edges)
    { }

    public UndirectedReadOnlyAdjacencyMatrix(IReadOnlyGraph graph)
    {
        _adjacencyMatrix = new List<(List<Node> row, Node node)>(graph.NodeCount);
        HashSet<IReadOnlyNode> unvisitedNodes = new(graph.GetNodes());
        int index = 0;
        while (!unvisitedNodes.IsEmpty())
        {
            graph.BreadthFirstSearch(unvisitedNodes.First(), node =>
            {
                unvisitedNodes.Remove(node);
                _adjacencyMatrix.Add(([], new Node(node, index++)));
            });
        }
    }

    public UndirectedReadOnlyAdjacencyMatrix(UndirectedReadOnlyAdjacencyMatrix graph)
    { }

    public int NodeCount { get; }

    public int EdgeCount { get; }

    public bool ContainsNode(Guid node)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNode(IReadOnlyNode node)
    {
        throw new NotImplementedException();
    }

    public bool ContainsEdge(Guid from, Guid to)
    {
        throw new NotImplementedException();
    }

    public bool ContainsEdge(IReadOnlyNode from, Guid to)
    {
        throw new NotImplementedException();
    }

    public bool ContainsEdge(Guid from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    public bool ContainsEdge(IReadOnlyNode from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    public bool IsDirected { get; }

    public bool IsWeighted { get; }

    public ModularVisibilityHashSet<IReadOnlyNode> GetNeighbors(Guid node)
    {
        throw new NotImplementedException();
    }

    public ModularVisibilityHashSet<ModularVisibilityHashSet<IReadOnlyNode>> GetStronglyConnectedComponents()
    {
        throw new NotImplementedException();
    }

    public IReadOnlyGraph Clone()
    {
        throw new NotImplementedException();
    }

    public IReadOnlyGraph GetStronglyConnectedComponentSubgraph(Guid node)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyGraph GetStronglyConnectedComponentSubgraph(IReadOnlyNode node)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyGraph GetSubgraph(IEnumerable<Guid> nodes)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyGraph GetSubgraph(IEnumerable<IReadOnlyNode> nodes)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<IReadOnlyNode> GetNodesEnumerator()
    {
        throw new NotImplementedException();
    }

    public IEnumerator<(IReadOnlyNode from, IReadOnlyNode to)> GetEdgesEnumerator()
    {
        throw new NotImplementedException();
    }

    public IEnumerator<IReadOnlyNode> GetNeighborsEnumerator(Guid node)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<IReadOnlyNode> GetNeighborsEnumerator(IReadOnlyNode node)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<IReadOnlyNode> GetStronglyConnectedComponentsEnumerator()
    {
        throw new NotImplementedException();
    }

    public IEnumerator<(IReadOnlyNode from, IReadOnlyNode to)> GetStronglyConnectedComponentsEdgesEnumerator()
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(Guid from, Guid to)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, Guid to)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(Guid from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(Guid from, Guid to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, Guid to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(Guid from, IReadOnlyNode to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm,
        int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, Guid to)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, Guid to)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, Guid to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, Guid to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, IReadOnlyNode to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm,
        int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, Guid to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(Guid from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    public List<IReadOnlyNode> GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to,
        ShortestPathPathfindingAlgorithm algorithm,
        int maxDepth)
    {
        throw new NotImplementedException();
    }

    public void BreadthFirstSearch(Guid node, Action<IReadOnlyNode> onNodeVisited)
    {
        throw new NotImplementedException();
    }

    public void BreadthFirstSearch(Guid startNode, Action<IReadOnlyNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference)
    {
        throw new NotImplementedException();
    }

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode> onNodeVisited)
    {
        throw new NotImplementedException();
    }

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference)
    {
        throw new NotImplementedException();
    }

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyNode> onNodeVisited)
    {
        throw new NotImplementedException();
    }

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference)
    {
        throw new NotImplementedException();
    }

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode> onNodeVisited)
    {
        throw new NotImplementedException();
    }

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode> onNodeVisited,
        Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference)
    {
        throw new NotImplementedException();
    }

    public class Node : IReadOnlyNode
    {
        public IReadOnlyGraph Graph { get; }
        public Guid Id { get; }
        public int Index { get; }

        public IReadOnlyList<IReadOnlyNode> GetOutgoingEdges()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<IReadOnlyNode> GetIncomingEdges()
        {
            throw new NotImplementedException();
        }

        public bool ContainsEdgeTo(Guid node)
        {
            throw new NotImplementedException();
        }

        public bool ContainsEdgeTo(IReadOnlyNode node)
        {
            throw new NotImplementedException();
        }

        public bool ContainsEdgeFrom(Guid node)
        {
            throw new NotImplementedException();
        }

        public bool ContainsEdgeFrom(IReadOnlyNode node)
        {
            throw new NotImplementedException();
        }
    }
}*/