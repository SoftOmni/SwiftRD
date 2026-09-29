using System;
using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public INode SetChildAt(int index, INode newNode)
    {
        throw new NotImplementedException();
    }
    
    public INode SetChildAt(int index, Node newNode)
    {
        throw new NotImplementedException();
    }
    
    public Node SetChildAt(int index, Node newNode, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }
    
    public Node SetChildAt(int index, Node newNode, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildAtAndDiscard(int index, INode newNode)
    {
        throw new NotImplementedException();
    }

    public void SetChildAtAndDiscard(int index, Node newNode)
    {
        throw new NotImplementedException();
    }

    public void SetChildAtAndDiscard(int index, Node newNode, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildAtAndDiscard(int index, Node newNode, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public Node SetChildAtLoose(int index, Node newNode)
    {
        throw new NotImplementedException();
    }

    public Node SetChildAtLoose(int index, Node newNode, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public Node SetChildAtLoose(int index, Node newNode, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildAtLooseAndDiscard(int index, Node newNode)
    {
        throw new NotImplementedException();
    }

    public void SetChildAtLooseAndDiscard(int index, Node newNode, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildAtLooseAndDiscard(int index, Node newNode, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public Node SetChildAtConcrete(int index, Node newNode)
    {
        throw new NotImplementedException();
    }

    public Node SetChildAtConcrete(int index, Node newNode, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public Node SetChildAtConcrete(int index, Node newNode, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildAtConcreteAndDiscard(int index, Node newNode)
    {
        throw new NotImplementedException();
    }

    public void SetChildAtConcreteAndDiscard(int index, Node newNode, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildAtConcreteAndDiscard(int index, Node newNode, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public INode SetChildAt<TNode>(int index, TNode newNode)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public Node SetChildAt<TNode>(int index, TNode newNode, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildAtAndDiscard<TNode>(int index, TNode newNode)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildAtAndDiscard<TNode>(int index, TNode newNode, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public Node SetChildAtLoose<TNode>(int index, TNode newNode)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public Node SetChildAtLoose<TNode>(int index, TNode newNode, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildAtLooseAndDiscard<TNode>(int index, TNode newNode)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildAtLooseAndDiscard<TNode>(int index, TNode newNode, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public Node SetChildAtConcrete<TNode>(int index, TNode newNode)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public Node SetChildAtConcrete<TNode>(int index, TNode newNode, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildAtConcreteAndDiscard<TNode>(int index, TNode newNode)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildAtConcreteAndDiscard<TNode>(int index, TNode newNode, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChild(INode child)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChild(INode child, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChild(INode child, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildAndDiscard(INode child)
    {
        throw new NotImplementedException();
    }

    public void SetChildAndDiscard(INode child, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildAndDiscard(INode child, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildLoose(INode child)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildLoose(INode child, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildLoose(INode child, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildLooseAndDiscard(INode child)
    {
        throw new NotImplementedException();
    }

    public void SetChildLooseAndDiscard(INode child, Action<INode, INode> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildLooseAndDiscard(INode child, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildConcrete(Node child)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildConcrete(Node child, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildConcrete(Node child, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildConcreteAndDiscard(Node child)
    {
        throw new NotImplementedException();
    }

    public void SetChildConcreteAndDiscard(Node child, Action<Node, Node> actionOnAdditionAndRemoval)
    {
        throw new NotImplementedException();
    }

    public void SetChildConcreteAndDiscard(Node child, Action<Node> actionOnAddition, Action<Node> actionOnRemoval)
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChild<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChild<TNode>(TNode child, Action<TNode, INode> actionOnAdditionAndRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChild<TNode>(TNode child, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildAndDiscard<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildAndDiscard<TNode>(TNode child, Action<TNode, INode> actionOnAdditionAndRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildAndDiscard<TNode>(TNode child, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildLoose<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildLoose<TNode>(TNode child, Action<TNode, INode> actionOnAdditionAndRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<INode> SetChildLoose<TNode>(TNode child, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildLooseAndDiscard<TNode>(TNode child)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildLooseAndDiscard<TNode>(TNode child, Action<TNode, INode> actionOnAdditionAndRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public void SetChildLooseAndDiscard<TNode>(TNode child, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : INode
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildConcrete<TNode>(TNode child)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildConcrete<TNode>(TNode child, Action<TNode, Node> actionOnAdditionAndRemoval)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public List<Node> SetChildConcrete<TNode>(TNode child, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildConcreteAndDiscard<TNode>(TNode child)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildConcreteAndDiscard<TNode>(TNode child, Action<TNode, Node> actionOnAdditionAndRemoval)
        where TNode : Node
    {
        throw new NotImplementedException();
    }

    public void SetChildConcreteAndDiscard<TNode>(TNode child, Action<TNode> actionOnAddition, Action<Node> actionOnRemoval)
        where TNode : Node
    {
        throw new NotImplementedException();
    }
}