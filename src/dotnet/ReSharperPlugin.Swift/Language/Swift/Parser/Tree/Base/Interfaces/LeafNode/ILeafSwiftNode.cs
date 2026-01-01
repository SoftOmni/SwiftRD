using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.LeafNodes;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Base.Interfaces.LeafNode;

public interface ILeafSwiftNode : Root.ISwiftNode, ILeafNode<Root.ISwiftNode>
{
    
}