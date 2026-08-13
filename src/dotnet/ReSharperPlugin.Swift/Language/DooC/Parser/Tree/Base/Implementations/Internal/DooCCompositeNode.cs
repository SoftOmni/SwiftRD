using JetBrains.ReSharper.Psi;
using SoftOmni.SwiftRd.Language.DocC;

namespace DefaultNamespace;

public abstract class DocCCompositeNode : DocCInternalNode<DocCCompositeNode>
{
    public override PsiLanguageType Language => DocCLanguage.Instance!;
}
