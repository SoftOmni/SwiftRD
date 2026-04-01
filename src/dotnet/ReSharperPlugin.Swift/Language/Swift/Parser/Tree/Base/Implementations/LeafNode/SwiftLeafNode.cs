using System;
using JetBrains.ReSharper.Psi;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.LeafNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Technology.Graphs;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;

public abstract class SwiftLeafNode<TSelf> :
    LeafNode<ISwiftNodeFamily<TSelf>, SwiftLeafNode<TSelf>, TSelf>,
    ISwiftLeafNode<TSelf>, ISwiftNode<TSelf>
    where TSelf : SwiftInternalNode<TSelf>
{
    protected SwiftLeafNode(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    protected SwiftLeafNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    { }

    public override PsiLanguageType Language => SwiftLanguage.Instance!;
    
    
}