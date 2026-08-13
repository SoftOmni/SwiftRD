using JetBrains.ReSharper.Psi;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.DocC;
using SoftOmni.SwiftRd.Language.DocC.Parser.Tree.Base.Interfaces;

namespace DefaultNamespace;

public abstract class DocCLeafNode<TSelf> : 
    LeafNode<IDocCNodeFamily<TSelf>, DocCLeafNode<TSelf>, TSelf>, 
    IDocCLeafNode<TSelf>
    where TSelf : DocCInternalNode<TSelf>
{
    protected DocCLeafNode(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    protected DocCLeafNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    { }

    public override PsiLanguageType Language => DocCLanguage.Instance!;
}
