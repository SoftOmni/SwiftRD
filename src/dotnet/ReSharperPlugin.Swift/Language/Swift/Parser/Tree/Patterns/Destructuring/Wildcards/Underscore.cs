using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns.Destructuring.Wildcards;

public class Underscore : SwiftLeafNode<SwiftCompositeNode>
{
    protected Underscore(IEditableBuffer underlyingBuffer) : base(underlyingBuffer)
    { }

    public override NodeType NodeType => SwiftNodeTypes.Underscore;
}