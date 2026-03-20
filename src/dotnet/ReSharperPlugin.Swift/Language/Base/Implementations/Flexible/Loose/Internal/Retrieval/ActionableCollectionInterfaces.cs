using System;
using ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Root;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.Root;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public interface IWithActionOnChildRetrievalLoose
{
    public Action<INode> OnChildRetrieval { get; }

    public void SetChildRetrievalAction(Action<INode> node);
}
    
public interface IWithActionOnChildRetrievalConcrete
{
    public Action<Node> OnChildRetrieval { get; }

    public void SetChildRetrievalAction(Action<Node> node);
}