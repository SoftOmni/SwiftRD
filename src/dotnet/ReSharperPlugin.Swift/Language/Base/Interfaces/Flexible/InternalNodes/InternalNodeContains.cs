using System;
using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.BaseNodes;

namespace SoftOmni.SwiftRd.Language.Base.Interfaces.Flexible.InternalNodes;

public partial interface IInternalNode
{
    public bool Contains(INode child);

    public bool Contains<TNode>(TNode child) where TNode : INode;
}