using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces;

public interface IModuleMapsNodeFamily<TSelf> :
    INodeFamily<IModuleMapsNodeFamily<TSelf>, TSelf, ModuleMapsLeafNode<TSelf>>
    where TSelf : class, IModuleMapsInternalNode<TSelf>;