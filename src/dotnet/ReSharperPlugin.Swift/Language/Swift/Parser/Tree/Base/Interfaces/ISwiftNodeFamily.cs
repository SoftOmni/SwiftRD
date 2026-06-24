
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces;

public interface ISwiftNodeFamily<TSelf> :
    INodeFamily<ISwiftNodeFamily<TSelf>, TSelf, SwiftLeafNode<TSelf>>
    where TSelf : SwiftInternalNode<TSelf>
{
    
}