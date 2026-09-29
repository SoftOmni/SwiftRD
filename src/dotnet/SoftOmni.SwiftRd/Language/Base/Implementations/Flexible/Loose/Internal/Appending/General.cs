using System;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Loose.InternalNodes;

public partial class InternalNode
{
    public int AppendChild(INode child)
    {
        return AttachChildForcibly(NumberOfChildren, child);
    }

    public int AppendChild(INode child, Action<INode> actionOnAddition)
    {
        int indexOfAttachment = AttachChildForcibly(NumberOfChildren, child);
        actionOnAddition(child);
        return indexOfAttachment;
    }
}