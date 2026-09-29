using System;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.Base;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public INode DetachChildAt(int index)
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtAndDiscard(int index)
    {
        throw new NotImplementedException();
    }

    public INode DetachChildAt(int index, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtAndDiscard(int index, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }
    
    public INode DetachChildAtLoose(int index)
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtLooseAndDiscard(int index)
    {
        throw new NotImplementedException();
    }

    public INode DetachChildAtLoose(int index, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtLooseAndDiscard(int index, Action<INode> onChildDetachment)
    {
        throw new NotImplementedException();
    }
    
    public Node DetachChildAtConcrete(int index)
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtConcreteAndDiscard(int index)
    {
        throw new NotImplementedException();
    }

    public Node DetachChildAtConcrete(int index, Action<Node> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtConcreteAndDiscard(int index, Action<Node> onChildDetachment)
    {
        throw new NotImplementedException();
    }

    public TNode DetachChildAt<TNode>(int index)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public TNode DetachChildAt<TNode>(int index, Action<INode> onChildDetachment)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void DetachChildAtAndDiscard<TNode>(int index)
        where TNode : INode
    {
        throw new NotImplementedException();
    }
}