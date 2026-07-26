using System;
using JetBrains.ReSharper.Psi;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.LeafNode;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.LeafNodes;

public abstract class ModuleMapsLeafNode<TSelf> :
    LeafNode<IModuleMapsNodeFamily<TSelf>, ModuleMapsLeafNode<TSelf>, TSelf>,
    IModuleMapsLeafNode<TSelf>
    where TSelf : class, IModuleMapsInternalNode<TSelf>
{
    protected ModuleMapsLeafNode(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    protected ModuleMapsLeafNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    { }

    public override PsiLanguageType Language => ModuleMapsLanguage.Instance!;

    IModuleMapsNode<TSelf> IModuleMapsLeafNode<TSelf>.CloneAsAttachedTo(TSelf newParent, int index)
    {
        throw new NotImplementedException();
    }

    IModuleMapsNode<TSelf> IModuleMapsLeafNode<TSelf>.CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    public TSelf CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    public TSelf CloneAsAttachedTo(TSelf newParent, int index)
    {
        throw new NotImplementedException();
    }
}