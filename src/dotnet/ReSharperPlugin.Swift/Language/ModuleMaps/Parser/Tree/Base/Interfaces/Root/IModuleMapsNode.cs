using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.Root;

public interface IModuleMapsNode<TSelf> : INode<IModuleMapsNodeFamily<TSelf>, TSelf, TSelf, ModuleMapsLeafNode<TSelf>>
    where TSelf : class, IModuleMapsInternalNode<TSelf>;