using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.InternalNode;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.LeafNode;

public interface IModuleMapsLeafNode<TSelf> :
    ILeafNode<IModuleMapsNodeFamily<TSelf>, TSelf, ModuleMapsLeafNode<TSelf>>
    where TSelf : class, IModuleMapsInternalNode<TSelf>;