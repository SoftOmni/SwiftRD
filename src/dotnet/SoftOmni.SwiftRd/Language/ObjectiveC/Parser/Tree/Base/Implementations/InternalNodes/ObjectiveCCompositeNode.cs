using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Base.Implementations.InternalNodes;

public abstract class ObjectiveCCompositeNode : ObjectiveCInternalNode<ObjectiveCCompositeNode>
{
    protected ObjectiveCCompositeNode(IEditableBuffer buffer)
        : base(buffer)
    { }

    protected ObjectiveCCompositeNode(ObjectiveCCompositeNode parent, int index, IEditableBuffer editableBuffer, IEnumerable<IObjectiveCNode<ObjectiveCCompositeNode>>? children = null)
        : base(parent, index, editableBuffer, children)
    { }

    protected ObjectiveCCompositeNode(ObjectiveCCompositeNode parent, int index, int textIndex, int lengthInParent, IEnumerable<IObjectiveCNode<ObjectiveCCompositeNode>>? children = null)
        : base(parent, index, textIndex, lengthInParent, children)
    { }

    protected ObjectiveCCompositeNode(IEditableBuffer buffer, IEnumerable<IObjectiveCNode<ObjectiveCCompositeNode>> children)
        : base(buffer, children)
    { }
}
