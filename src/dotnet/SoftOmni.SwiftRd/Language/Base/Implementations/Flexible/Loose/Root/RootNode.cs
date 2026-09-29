using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.InternalNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.RootNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.Root;

public abstract class RootNode : InternalNode, IRootNode
{
    protected RootNode()
    { }

    protected RootNode(IEditableBuffer buffer)
        : base(buffer)
    { }

    protected RootNode(IEnumerator<INode> childEnumerator, bool mustDispose = true)
        : base(childEnumerator, mustDispose)
    { }

    protected RootNode(IEnumerable<INode> children)
        : base(children)
    { }
}