using JetBrains.ReSharper.Psi;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.DooC;
using SoftOmni.SwiftRd.Language.DooC.Parser.Tree.Base.Interfaces;

namespace DefaultNamespace;

public abstract class DooCLeafNode<TSelf> : 
    LeafNode<IDooCNodeFamily<TSelf>, DooCLeafNode<TSelf>, TSelf>, 
    IDooCLeafNode<TSelf>
    where TSelf : DooCInternalNode<TSelf>
{
    protected DooCLeafNode(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    protected DooCLeafNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    { }

    public override PsiLanguageType Language => DooCLanguage.Instance!;
}
