using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.LeafNode;

public interface IModuleMapsLeafNode<TSelf> :
    ILeafNode<IModuleMapsNodeFamily<TSelf>, TSelf, ModuleMapsLeafNode<TSelf>>,
    IModuleMapsNode<TSelf> where TSelf : class, IModuleMapsInternalNode<TSelf>
{
    new TSelf? GetParent();
    
    new void AttachToParent(TSelf node, int index);

    new IModuleMapsNode<TSelf> CloneAsAttachedTo(TSelf newParent, int index);

    new IModuleMapsNode<TSelf> CloneAsDetached();
}