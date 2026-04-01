using System;
using JetBrains.ReSharper.Psi;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Concretely.ErrorNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.Base;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.ErrorNodes;

public class SwiftErrorLeafNode<TSelf> :
    ErrorNode<ISwiftNodeFamily<TSelf>, SwiftNode<TSelf>, TSelf, SwiftLeafNode<TSelf>>, ISwiftNode<SwiftCompositeNode>
    where TSelf : SwiftInternalNode<TSelf>
{
    protected SwiftErrorLeafNode(IEditableBuffer underlyingBuffer, string message)
        : base(underlyingBuffer, message)
    { }

    protected SwiftErrorLeafNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex, string message)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex, message)
    { }

    public SwiftCompositeNode? GetParent()
    {
        throw new NotImplementedException();
    }

    SwiftCompositeNode INode<ISwiftNodeFamily<SwiftCompositeNode>, SwiftCompositeNode, SwiftCompositeNode, SwiftLeafNode<SwiftCompositeNode>>.CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    public SwiftCompositeNode CloneAsAttachedTo(SwiftCompositeNode newParent, int index)
    {
        throw new NotImplementedException();
    }

    public void AttachToParent(SwiftCompositeNode newParent, int parentIndex)
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

    public override PsiLanguageType Language => SwiftLanguage.Instance!;
}