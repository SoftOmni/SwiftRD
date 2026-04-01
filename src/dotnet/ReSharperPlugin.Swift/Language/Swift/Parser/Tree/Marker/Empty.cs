using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Marker;

public class Empty : SwiftLeafNode, IMarker
{
    public Empty(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.Empty)
    { }

    public Empty(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.Empty)
    { }
}