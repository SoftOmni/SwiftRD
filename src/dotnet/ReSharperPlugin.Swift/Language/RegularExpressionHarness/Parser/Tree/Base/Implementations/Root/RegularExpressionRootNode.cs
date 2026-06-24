using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Concretely.Root;

namespace SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.Root;

public class RegularExpressionRootNode<TSelf> : RootNode<IRegularExpressionNodeFamily<TSelf>, TSelf,
    RegularExpressionLeafNode<TSelf>>, IRegularExpressionInternalNode<TSelf>
    where TSelf : RegularExpressionRootNode<TSelf>
{
    protected RegularExpressionRootNode(IEditableBuffer buffer)
        : base(buffer)
    { }

    public override NodeType NodeType { get; }
    
    public override PsiLanguageType Language { get; }
}
