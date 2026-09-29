using System;
using SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public int AppendChild(Node child)
    {
        return AttachChildForcibly(NumberOfChildren, child);
    }

    public int AppendChild(Node child, Action<Node> actionOnAddition)
    {
        int indexOfAttachment = AttachChildForcibly(NumberOfChildren, child);
        actionOnAddition(child);
        return indexOfAttachment;
    }
}