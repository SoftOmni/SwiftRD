using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Marker;

public class EndOfFile : SwiftLeafNode, IMarker
{
    public EndOfFile(IEditableBuffer buffer) 
        : base(buffer, NodeTypes.NodeTypes.EndOfFile)
    { }

    public EndOfFile(SwiftInternalNode parent, IEditableBuffer buffer) 
        : base(parent, buffer, NodeTypes.NodeTypes.EndOfFile)
    { }
}