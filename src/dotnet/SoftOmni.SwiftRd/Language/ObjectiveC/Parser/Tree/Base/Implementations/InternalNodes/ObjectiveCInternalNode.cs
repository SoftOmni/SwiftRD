using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Constrained.Root;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.LeafNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;

public abstract class ObjectiveCInternalNode<TSelf> : InternalNode<IObjectiveCNodeFamily<TSelf>, TSelf, ObjectiveCLeafNode<TSelf>>,
    IObjectiveCInternalNode<TSelf>, IObjectiveCNode<TSelf>
    where TSelf : ObjectiveCInternalNode<TSelf>
{
    protected ObjectiveCInternalNode(IEditableBuffer buffer)
        : base(buffer)
    { }

    protected ObjectiveCInternalNode(TSelf parent, int index, IEditableBuffer editableBuffer, IEnumerable<IObjectiveCNode<TSelf>>? children = null)
        : base(parent, index, editableBuffer, children)
    { }

    protected ObjectiveCInternalNode(TSelf parent, int index, int textIndex, int lengthInParent, IEnumerable<IObjectiveCNode<TSelf>>? children = null)
        : base(parent, index, textIndex, lengthInParent, children)
    { }

    protected ObjectiveCInternalNode(IEditableBuffer buffer, IEnumerable<IObjectiveCNode<TSelf>> children)
        : base(buffer, children)
    { }
}
