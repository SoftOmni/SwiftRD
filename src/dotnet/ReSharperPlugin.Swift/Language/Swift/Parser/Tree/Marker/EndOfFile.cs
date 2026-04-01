using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Marker;

public class EndOfFile : SwiftLeafNode, IMarker
{
    public EndOfFile(IEditableBuffer buffer) 
        : base(buffer, SwiftNodeTypes.EndOfFile)
    { }

    public EndOfFile(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, parentbuffer, SwiftNodeTypes.EndOfFile)
    { }
}