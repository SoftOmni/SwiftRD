using JetBrains.ReSharper.Psi;
using SoftOmni.SwiftRd.Language.DooC;

namespace DefaultNamespace;

public abstract class DooCCompositeNode : DooCInternalNode<DooCCompositeNode>
{
    public override PsiLanguageType Language => DooCLanguage.Instance!;
}
