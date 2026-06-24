using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Concretely.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.Root;

public class SwiftRootNode<TSelf> : RootNode<ISwiftNodeFamily<TSelf>, TSelf, SwiftLeafNode<TSelf>>, ISwiftInternalNode<TSelf>
    where TSelf
{
    protected SwiftRootNode(IEditableBuffer buffer)
        : base(buffer)
    {
        
    }

    public override NodeType NodeType => SwiftNodeTypes.Internal;

    public override PsiLanguageType Language => SwiftLanguage.Instance!;
}