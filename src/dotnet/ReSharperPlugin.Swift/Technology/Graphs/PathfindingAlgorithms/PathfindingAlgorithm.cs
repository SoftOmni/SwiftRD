using System;
using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Technology.Graphs.PathfindingAlgorithms;

public abstract class PathfindingAlgorithm
{
    private readonly ModularVisibilityHashSet<IReadOnlyNode> _startNodes = [];
    
    private readonly ModularVisibilityHashSet<IReadOnlyNode> _targetNodes = [];
    
    private List<IReadOnlyNode>? _path;
    
    protected PathfindingAlgorithm(IReadOnlyGraph graph, IReadOnlyNode startNode, IReadOnlyNode targetNode)
    {
        Graph = graph;
        
        CheckNode(startNode);
        CheckNode(targetNode);
        
        _startNodes.Add(startNode);
        _targetNodes.Add(targetNode);
    }

    protected PathfindingAlgorithm(IReadOnlyGraph graph, IReadOnlyNode startNode,
        IReadOnlySet<IReadOnlyNode> targetNodes)
    {
        Graph = graph;
        
        CheckNode(startNode);
        CheckNodes(targetNodes);
        
        _startNodes.Add(startNode);
        _targetNodes.AddRange(targetNodes);
    }
    
    protected PathfindingAlgorithm(IReadOnlyGraph graph, IReadOnlySet<IReadOnlyNode> startNodes, IReadOnlyNode targetNode)
    {
        Graph = graph;
        
        CheckNodes(startNodes);
        CheckNode(targetNode);
        
        _startNodes.AddRange(startNodes);
        _targetNodes.Add(targetNode);
    }
    
    protected PathfindingAlgorithm(IReadOnlyGraph graph, IReadOnlySet<IReadOnlyNode> startNodes, IReadOnlySet<IReadOnlyNode> targetNodes)
    {
        Graph = graph;
        
        CheckNodes(startNodes);
        CheckNodes(targetNodes);
        
        _startNodes.AddRange(startNodes);
        _targetNodes.AddRange(targetNodes);
    }
    
    protected IReadOnlySet<IReadOnlyNode> StartNodes => _startNodes;
    
    protected IReadOnlySet<IReadOnlyNode> TargetNodes => _targetNodes;
    
    public IReadOnlyGraph Graph { get; }

    protected abstract List<IReadOnlyNode>? Pathfind();
    
    public virtual List<IReadOnlyNode>? FindPath()
    {
        _path = Pathfind();
        return _path;
    }

    private void CheckNode(IReadOnlyNode node)
    {
        if (!ReferenceEquals(node.Graph, Graph))
        {
            throw new ArgumentException("The node does not belong to the graph.", nameof(node));
        }
    }

    private void CheckNodes(IReadOnlyCollection<IReadOnlyNode> nodes)
    {
        foreach (IReadOnlyNode? node in nodes)
        {
            CheckNode(node);
        }
    }
}