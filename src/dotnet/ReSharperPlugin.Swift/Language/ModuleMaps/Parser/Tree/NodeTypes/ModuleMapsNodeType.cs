using System;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.NodeTypes;

public abstract class ModuleMapsNodeType : NodeType
{
    protected ModuleMapsNodeType(string name, int index, NodeTypeFlags flags)
        : base(name, index, flags)
    { }

    protected ModuleMapsNodeType(string name, int index, Type nodeType)
        : base(name, index, nodeType)
    { }
    
    
}

public class FileInternalNodeType : ModuleMapsNodeType
{
    public FileInternalNodeType(string name, int index, NodeTypeFlags flags)
        : base(name, index, flags)
    { }

    public FileInternalNodeType(string name, int index, Type nodeType)
        : base(name, index, nodeType)
    { }
}
