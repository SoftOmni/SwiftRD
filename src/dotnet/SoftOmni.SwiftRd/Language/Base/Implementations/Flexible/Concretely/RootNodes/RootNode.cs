using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.RootNodes;

public abstract class RootNode : InternalNode
{
    protected RootNode()
    { }

    protected RootNode(IEditableBuffer buffer)
        : base(buffer)
    { }

    protected RootNode(IEnumerator<Node> childEnumerator, bool mustDispose = true)
        : base(childEnumerator, mustDispose)
    { }

    protected RootNode(IEnumerable<Node> children)
        : base(children)
    { }
}