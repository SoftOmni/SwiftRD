using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Marker;

public class EndOfFile : SwiftLeafNode<SwiftCompositeNode>, IMarker
{
    public StartOfFile StartOfFile { get; }

    public EndOfFile(IEditableBuffer buffer, StartOfFile startOfFile)
        : base(buffer)
    {
        StartOfFile = startOfFile;
    }

    public EndOfFile(SwiftCompositeNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer,
        StartOfFile startOfFile)
        : base(buffer, parent, parentIndex, parentTextIndex)
    {
        StartOfFile = startOfFile;
    }

    public override NodeType NodeType => SwiftNodeTypes.EndOfFile;
}
