using System;
using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Implementations.Flexible.Concretely.InternalNodes;

public partial class InternalNode
{
    public INode GetChildAt(int index)
    {
        return _children[index];
    }

    public INode GetChildAt(int index, Action<INode> onChildRetrieval)
    {
        onChildRetrieval(_children[index]);
        return _children[index];
    }

    public INode GetLooseChildAt(int index)
        => GetChildAt(index);
}