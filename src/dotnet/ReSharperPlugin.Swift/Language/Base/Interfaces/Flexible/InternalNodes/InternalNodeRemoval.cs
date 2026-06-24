using System;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;

public partial interface IInternalNode
{
    public INode RemoveChildAt(int index);

    public INode RemoveChildAt(int index, Action<INode> onChildDetachment);

    public void RemoveChildAtAndDiscard(int index);

    public void RemoveChildAtAndDiscard(int index, Action<INode> onChildDetachment);
}