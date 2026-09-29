using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using SoftOmni.SwiftRd.Technology.Graphs.PathfindingAlgorithms;

namespace SoftOmni.SwiftRd.Technology.Graphs.StateMachines;

public class ReadOnlyStateMachine<TState> : IReadOnlyGraph<TState>
{
    public Guid StartNodeId => StartNode.Id;
    
    public ReadOnlyStateMachineNode StartNode { get; }
    
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

    public IReadOnlyList<IReadOnlyNode> GetNodes()
    {
        throw new NotImplementedException();
    }

    public ModularVisibilityHashSet<IReadOnlyNode> GetNeighbors(Guid node)
    {
        throw new NotImplementedException();
    }

    public ModularVisibilityHashSet<ModularVisibilityHashSet<IReadOnlyNode>> GetStronglyConnectedComponents()
    {
        throw new NotImplementedException();
    }

    public IReadOnlyGraph<TState> Clone()
    {
        throw new NotImplementedException();
    }

    public IReadOnlyGraph<TState> GetStronglyConnectedComponentSubgraph(Guid node)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyGraph<TState> GetStronglyConnectedComponentSubgraph(IReadOnlyNode node)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyGraph<TState> GetSubgraph(IEnumerable<Guid> nodes)
    {
        throw new NotImplementedException();
    }

    public IReadOnlyGraph<TState> GetSubgraph(IEnumerable<IReadOnlyNode> nodes)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<IReadOnlyNode<TState>> GetNodesEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator<(IReadOnlyNode<TState> from, IReadOnlyNode<TState> to)> IReadOnlyGraph<TState>.GetEdgesEnumerator()
    {
        throw new NotImplementedException();
    }

    public IEnumerator<IReadOnlyNode<TState>> GetNeighborsEnumerator(Guid node)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<IReadOnlyNode<TState>> GetNeighborsEnumerator(IReadOnlyNode node)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<IReadOnlyNode<TState>> GetStronglyConnectedComponentsEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator<(IReadOnlyNode<TState> from, IReadOnlyNode<TState> to)> IReadOnlyGraph<TState>.GetStronglyConnectedComponentsEdgesEnumerator()
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(Guid from, Guid to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(IReadOnlyNode from, Guid to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(Guid from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(IReadOnlyNode from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(Guid from, Guid to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(IReadOnlyNode from, Guid to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(Guid from, IReadOnlyNode to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(Guid from, Guid to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(IReadOnlyNode from, Guid to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(Guid from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(Guid from, Guid to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(IReadOnlyNode from, Guid to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(Guid from, IReadOnlyNode to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(IReadOnlyNode from, Guid to, ShortestPathPathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(Guid from, IReadOnlyNode to, ShortestPathPathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, ShortestPathPathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(IReadOnlyNode from, Guid to, ShortestPathPathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(Guid from, IReadOnlyNode to, ShortestPathPathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode<TState>> IReadOnlyGraph<TState>.GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, ShortestPathPathfindingAlgorithm algorithm,
        int maxDepth)
    {
        throw new NotImplementedException();
    }

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode<TState>> onNodeVisited)
    {
        throw new NotImplementedException();
    }

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode<TState>> onNodeVisited, Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference)
    {
        throw new NotImplementedException();
    }

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyNode<TState>> onNodeVisited)
    {
        throw new NotImplementedException();
    }

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyNode<TState>> onNodeVisited, Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference)
    {
        throw new NotImplementedException();
    }

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode<TState>> onNodeVisited)
    {
        throw new NotImplementedException();
    }

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode<TState>> onNodeVisited, Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference)
    {
        throw new NotImplementedException();
    }

    public bool ContainsNode(TState node)
    {
        throw new NotImplementedException();
    }

    public bool ContainsEdge(TState from, TState to)
    {
        throw new NotImplementedException();
    }

    IReadOnlyGraph IReadOnlyGraph.Clone()
    {
        return Clone();
    }

    IReadOnlyGraph IReadOnlyGraph.GetStronglyConnectedComponentSubgraph(Guid node)
    {
        return GetStronglyConnectedComponentSubgraph(node);
    }

    IReadOnlyGraph IReadOnlyGraph.GetStronglyConnectedComponentSubgraph(IReadOnlyNode node)
    {
        return GetStronglyConnectedComponentSubgraph(node);
    }

    IReadOnlyGraph IReadOnlyGraph.GetSubgraph(IEnumerable<Guid> nodes)
    {
        return GetSubgraph(nodes);
    }

    IReadOnlyGraph IReadOnlyGraph.GetSubgraph(IEnumerable<IReadOnlyNode> nodes)
    {
        return GetSubgraph(nodes);
    }

    IEnumerator<IReadOnlyNode> IReadOnlyGraph.GetNodesEnumerator()
    {
        return GetNodesEnumerator();
    }

    IEnumerator<(IReadOnlyNode from, IReadOnlyNode to)> IReadOnlyGraph.GetEdgesEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator<IReadOnlyNode> IReadOnlyGraph.GetNeighborsEnumerator(Guid node)
    {
        return GetNeighborsEnumerator(node);
    }

    IEnumerator<IReadOnlyNode> IReadOnlyGraph.GetNeighborsEnumerator(IReadOnlyNode node)
    {
        return GetNeighborsEnumerator(node);
    }

    IEnumerator<IReadOnlyNode> IReadOnlyGraph.GetStronglyConnectedComponentsEnumerator()
    {
        return GetStronglyConnectedComponentsEnumerator();
    }

    IEnumerator<(IReadOnlyNode from, IReadOnlyNode to)> IReadOnlyGraph.GetStronglyConnectedComponentsEdgesEnumerator()
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(Guid from, Guid to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(IReadOnlyNode from, Guid to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(Guid from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(IReadOnlyNode from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(Guid from, Guid to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(IReadOnlyNode from, Guid to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(Guid from, IReadOnlyNode to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(Guid from, Guid to, PathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(IReadOnlyNode from, Guid to, PathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(Guid from, IReadOnlyNode to, PathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetPathBetween(IReadOnlyNode from, IReadOnlyNode to, PathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(Guid from, Guid to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(IReadOnlyNode from, Guid to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(Guid from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(Guid from, Guid to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(IReadOnlyNode from, Guid to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(Guid from, IReadOnlyNode to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(IReadOnlyNode from, Guid to, ShortestPathPathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(Guid from, IReadOnlyNode to, ShortestPathPathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, ShortestPathPathfindingAlgorithm algorithm)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(Guid from, Guid to, ShortestPathPathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(IReadOnlyNode from, Guid to, ShortestPathPathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(Guid from, IReadOnlyNode to, ShortestPathPathfindingAlgorithm algorithm, int maxDepth)
    {
        throw new NotImplementedException();
    }

    List<IReadOnlyNode> IReadOnlyGraph.GetShortestPathBetween(IReadOnlyNode from, IReadOnlyNode to, ShortestPathPathfindingAlgorithm algorithm,
        int maxDepth)
    {
        throw new NotImplementedException();
    }

    public void BreadthFirstSearch(Guid node, Action<IReadOnlyNode> onNodeVisited)
    {
        throw new NotImplementedException();
    }

    public void BreadthFirstSearch(Guid startNode, Action<IReadOnlyNode> onNodeVisited, Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference)
    {
        throw new NotImplementedException();
    }

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode> onNodeVisited)
    {
        throw new NotImplementedException();
    }

    public void BreadthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode> onNodeVisited, Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference)
    {
        throw new NotImplementedException();
    }

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyNode> onNodeVisited)
    {
        throw new NotImplementedException();
    }

    public void DepthFirstSearch(Guid startNode, Action<IReadOnlyNode> onNodeVisited, Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference)
    {
        throw new NotImplementedException();
    }

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode> onNodeVisited)
    {
        throw new NotImplementedException();
    }

    public void DepthFirstSearch(IReadOnlyNode startNode, Action<IReadOnlyNode> onNodeVisited, Func<ICollection<IReadOnlyNode>, IEnumerator<IReadOnlyNode>> orderNeighborPreference)
    {
        throw new NotImplementedException();
    }

    public IEnumerator<TState> GetEnumerator()
    {
        throw new NotImplementedException();
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public int Count { get; }

    public class ReadOnlyStateMachineNode : IReadOnlyNode<TState>
    {
        private ReadOnlyStateMachine<TState> _stateMachine;

        public bool ContainsEdgeFrom(TState value)
        {
            throw new NotImplementedException();
        }

        public bool ContainsEdgeTo(TState value)
        {
            throw new NotImplementedException();
        }

        public bool TryGetEdgeFrom(TState value, [NotNullWhen(false)] out IReadOnlyNode<TState>? edge)
        {
            throw new NotImplementedException();
        }

        public bool TryGetEdgeTo(TState value, [NotNullWhen(false)] out IReadOnlyNode<TState>? edge)
        {
            throw new NotImplementedException();
        }

        IReadOnlyGraph IReadOnlyNode.Graph => Graph;

        public IReadOnlyGraph<TState> Graph => _stateMachine;

        public TState Value { get; }
        
        public Guid Id { get; }
        
        public bool IsAcceptState { get; }
        
        public int Index { get; }
        IReadOnlyList<IReadOnlyNode> IReadOnlyNode.GetOutgoingEdges()
        {
            return GetOutgoingEdges();
        }

        public IReadOnlyList<IReadOnlyNode<TState>> GetIncomingEdges()
        {
            throw new NotImplementedException();
        }

        public IReadOnlyList<IReadOnlyNode<TState>> GetOutgoingEdges()
        {
            throw new NotImplementedException();
        }

        IReadOnlyList<IReadOnlyNode> IReadOnlyNode.GetIncomingEdges()
        {
            return GetIncomingEdges();
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
}