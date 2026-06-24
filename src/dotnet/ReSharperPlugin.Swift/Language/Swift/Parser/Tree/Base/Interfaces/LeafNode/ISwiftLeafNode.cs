using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.LeafNode;

public interface ISwiftLeafNode<TSelf> :
    ILeafNode<ISwiftNodeFamily<TSelf>, TSelf, SwiftLeafNode<TSelf>>,
    ISwiftNode<TSelf>
    where TSelf : SwiftInternalNode<TSelf>
{
    new TSelf? GetParent();
    
    new void AttachToParent(TSelf node, int index);

    new ISwiftLeafNode<TSelf> CloneAsAttachedTo(TSelf newParent, int index);

    new ISwiftLeafNode<TSelf> CloneAsDetached();
}
