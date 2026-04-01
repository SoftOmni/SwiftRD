using JetBrains.ReSharper.Psi;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Base;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.Base;

public abstract class SwiftNode<TSelf> :
    Node<ISwiftNodeFamily<TSelf>, SwiftNode<TSelf>, TSelf, SwiftLeafNode<TSelf>>
    where TSelf : SwiftInternalNode<TSelf>
{
    protected SwiftNode(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    protected SwiftNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    { }

    public override PsiLanguageType Language => SwiftLanguage.Instance!;
}