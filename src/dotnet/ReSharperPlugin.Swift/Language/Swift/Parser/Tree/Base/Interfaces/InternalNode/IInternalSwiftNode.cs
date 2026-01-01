using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.InternalNodes;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Base.Interfaces.InternalNode;

public interface IInternalSwiftNode : Root.ISwiftNode, IInternalNode<Root.ISwiftNode>
{
    
}