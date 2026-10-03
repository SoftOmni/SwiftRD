using JetBrains.ReSharper.Psi;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Base;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.Base;

public abstract class ObjectiveCNode<TSelf> : Node<IObjectiveCNodeFamily<TSelf>, ObjectiveCNode<TSelf>, TSelf, ObjectiveCLeafNode<TSelf>>
    where TSelf : ObjectiveCInternalNode<TSelf>
{
    protected ObjectiveCNode(IEditableBuffer underlyingBuffer)
        : base(underlyingBuffer)
    { }

    protected ObjectiveCNode(IEditableBuffer underlyingBuffer, TSelf parentNode, int parentIndex, int parentTextIndex)
        : base(underlyingBuffer, parentNode, parentIndex, parentTextIndex)
    { }

    public override PsiLanguageType Language => ObjectiveCLanguage.Instance!;
}
