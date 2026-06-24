using System;
using JetBrains.ReSharper.Psi;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Concretely.ErrorNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.Base;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.ModuleMapsRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.ErrorNodes;

public class ModuleMapsErrorLeafNode<TSelf> :
    ErrorNode<IModuleMapsNodeFamily<TSelf>, ModuleMapsNode<TSelf>, TSelf, ModuleMapsLeafNode<TSelf>>, IModuleMapsNode<ModuleMapsCompositeNode>
    where TSelf : ModuleMapsInternalNode<TSelf>
{
    protected ModuleMapsErrorLeafNode(IEditableBuffer underlyingBuffer, string message)
        : base(underlyingBuffer, message)
    { }

    protected ModuleMapsErrorLeafNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex, string message)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex, message)
    { }

    public ModuleMapsCompositeNode? GetParent()
    {
        throw new NotImplementedException();
    }

    ModuleMapsCompositeNode INode<IModuleMapsNodeFamily<ModuleMapsCompositeNode>, ModuleMapsCompositeNode, ModuleMapsCompositeNode, ModuleMapsLeafNode<ModuleMapsCompositeNode>>.CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    public ModuleMapsCompositeNode CloneAsAttachedTo(ModuleMapsCompositeNode newParent, int index)
    {
        throw new NotImplementedException();
    }

    public void AttachToParent(ModuleMapsCompositeNode newParent, int parentIndex)
    {
        throw new NotImplementedException();
    }

    public override INode CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    public override INode CloneAsAttachedTo(IInternalNode newParent, int index)
    {
        throw new NotImplementedException();
    }

    public override PsiLanguageType Language => ModuleMapsLanguage.Instance!;
}