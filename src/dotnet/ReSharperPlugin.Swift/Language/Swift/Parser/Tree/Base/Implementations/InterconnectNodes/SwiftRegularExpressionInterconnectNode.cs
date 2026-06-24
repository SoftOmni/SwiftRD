using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.InternalNode;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Concretely.InterconnectNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InterconnectNodes;

public class SwiftRegularExpressionInterconnectNode : 
    InterconnectNode<ISwiftNodeFamily<SwiftCompositeNode>, SwiftCompositeNode, SwiftLeafNode<SwiftCompositeNode>, RegularExpressionCompositeNode>
{
    public SwiftRegularExpressionInterconnectNode(RegularExpressionCompositeNode equivalentNode)
        : base(equivalentNode)
    { }

    public SwiftRegularExpressionInterconnectNode(RegularExpressionCompositeNode equivalentNode, SwiftCompositeNode parent, int index)
        : base(equivalentNode, parent, index)
    { }

    public SwiftRegularExpressionInterconnectNode(RegularExpressionCompositeNode equivalentNode, SwiftCompositeNode parent, int index, int textIndex, int lengthInParent)
        : base(equivalentNode, parent, index, textIndex, lengthInParent)
    { }

    public override PsiLanguageType Language => SwiftLanguage.Instance!;

    public override NodeType NodeType => SwiftNodeTypes.RegularExpressionLiteral;
}
