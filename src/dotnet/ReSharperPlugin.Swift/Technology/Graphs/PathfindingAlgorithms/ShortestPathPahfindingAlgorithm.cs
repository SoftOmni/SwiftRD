using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Technology.Graphs.PathfindingAlgorithms;

//TODO: adjust this
public abstract class ShortestPathPathfindingAlgorithm : PathfindingAlgorithm
{
    protected ShortestPathPathfindingAlgorithm(IReadOnlyGraph graph, IReadOnlyNode startNode, IReadOnlyNode targetNode)
        : base(graph, startNode, targetNode)
    { }

    protected ShortestPathPathfindingAlgorithm(IReadOnlyGraph graph, IReadOnlyNode startNode, IReadOnlySet<IReadOnlyNode> targetNodes)
        : base(graph, startNode, targetNodes)
    { }

    protected ShortestPathPathfindingAlgorithm(IReadOnlyGraph graph, IReadOnlySet<IReadOnlyNode> startNodes, IReadOnlyNode targetNode)
        : base(graph, startNodes, targetNode)
    { }

    protected ShortestPathPathfindingAlgorithm(IReadOnlyGraph graph, IReadOnlySet<IReadOnlyNode> startNodes, IReadOnlySet<IReadOnlyNode> targetNodes)
        : base(graph, startNodes, targetNodes)
    { }
}