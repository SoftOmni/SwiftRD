using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Marker;


public class StartOfFile : SwiftLeafNode<SwiftCompositeNode>, IMarker
{
    public EndOfFile EndOfFile { get; }

    public StartOfFile(IEditableBuffer buffer, EndOfFile endOfFile)
        : base(buffer)
    {
        EndOfFile = endOfFile;
    }

    public StartOfFile(SwiftCompositeNode parent, int parentIndex, int parentTextIndex, IEditableBuffer buffer,
        EndOfFile endOfFile)
        : base(buffer, parent, parentIndex, parentTextIndex)
    {
        EndOfFile = endOfFile;
    }

    public override NodeType NodeType => SwiftNodeTypes.StartOfFile;
}