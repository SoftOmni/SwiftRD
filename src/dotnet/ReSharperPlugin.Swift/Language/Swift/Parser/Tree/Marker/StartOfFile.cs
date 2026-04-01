using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Marker;

public class StartOfFile : SwiftLeafNode, IMarker
{
    public StartOfFile(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.StartOfFile)
    { }

    public StartOfFile(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, SwiftNodeTypes.StartOfFile)
    { }
}