using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Marker;

public class Empty : SwiftLeafNode<SwiftCompositeNode>, IMarker
{
    public Empty(IEditableBuffer buffer) 
        : base(buffer)
    { }

    public Empty(SwiftCompositeNode parent, int parentIndex, int parentTextOffset, IEditableBuffer buffer) 
        : base(buffer, parent, parentIndex, parentTextOffset)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Empty;
}