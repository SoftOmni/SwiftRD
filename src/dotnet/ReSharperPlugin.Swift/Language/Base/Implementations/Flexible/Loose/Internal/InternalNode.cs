using System.Collections.Generic;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using ReSharperPlugin.Swift.Language.Base.Interfaces.Flexible.InternalNodes;

namespace ReSharperPlugin.Swift.Language.Base.Implementations.Flexible.Loose.Internal;

public abstract partial class InternalNode : TreeElement, IInternalNode
{
    protected List<IInternalNode> Children;
}