using System;
using JetBrains.ReSharper.Psi;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.LeafNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces.LeafNode;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;

public abstract class ObjectiveCLeafNode<TSelf> : LeafNode<IObjectiveCNodeFamily<TSelf>, ObjectiveCLeafNode<TSelf>, TSelf>, IObjectiveCLeafNode<TSelf>
    where TSelf : ObjectiveCInternalNode<TSelf>
{
    protected ObjectiveCLeafNode(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    protected ObjectiveCLeafNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    { }

    public override PsiLanguageType Language => ObjectiveCLanguage.Instance!;
    
    IObjectiveCLeafNode<TSelf> IObjectiveCLeafNode<TSelf>.CloneAsAttachedTo(TSelf newParent, int index)
    {
        throw new NotImplementedException();
    }

    IObjectiveCLeafNode<TSelf> IObjectiveCLeafNode<TSelf>.CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    TSelf INode<IObjectiveCNodeFamily<TSelf>, TSelf, TSelf, ObjectiveCLeafNode<TSelf>>.CloneAsDetached()
    {
        throw new NotImplementedException();
    }

    TSelf INode<IObjectiveCNodeFamily<TSelf>, TSelf, TSelf, ObjectiveCLeafNode<TSelf>>.CloneAsAttachedTo(TSelf newParent, int index)
    {
        throw new NotImplementedException();
    }
}