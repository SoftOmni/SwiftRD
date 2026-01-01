using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.InternalNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.LeafNodes;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Constrained.Root;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Base.Interfaces.Root;

public interface ISwiftNode : INode<IInternalNode<ISwiftNode>, ILeafNode<ISwiftNode>>
{
    
}