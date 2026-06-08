using JetBrains.ReSharper.Psi;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Base;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.Base;

public abstract class ModuleMapsNode<TSelf> :
    Node<IModuleMapsNodeFamily<TSelf>, ModuleMapsNode<TSelf>, TSelf, ModuleMapsLeafNode<TSelf>>
    where TSelf : ModuleMapsInternalNode<TSelf>
{
    protected ModuleMapsNode(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    protected ModuleMapsNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    { }

    public override PsiLanguageType Language => SwiftLanguage.Instance!;
}