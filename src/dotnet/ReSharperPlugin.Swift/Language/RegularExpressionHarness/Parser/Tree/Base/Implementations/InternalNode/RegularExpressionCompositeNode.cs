using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using SoftOmni.SwiftRd.Language.RegularExpressionHarness;

namespace SoftOmni.SwiftRd.Rider.Language.RegularExpressionHarness.Parser.Tree.Base.Implementations.InternalNode;

public abstract class RegularExpressionCompositeNode : RegularExpressionInternalNode<RegularExpressionCompositeNode>
{
    public abstract override NodeType NodeType { get; }
    
    public override PsiLanguageType Language => SwiftRegularExpressionLanguage.Instance!;
}
