using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.InternalNodes;

public abstract class ModuleMapsCompositeNode : ModuleMapsInternalNode<ModuleMapsCompositeNode>
{
    protected ModuleMapsCompositeNode(IEditableBuffer buffer)
        : base(buffer)
    { }

    protected ModuleMapsCompositeNode(ModuleMapsCompositeNode parent, int index, IEditableBuffer editableBuffer,
        IEnumerable<IModuleMapsNode<ModuleMapsCompositeNode>>? children = null)
        : base(parent, index, editableBuffer, children)
    { }

    protected ModuleMapsCompositeNode(ModuleMapsCompositeNode parent, int index, int textIndex, int lengthInParent,
        IEnumerable<IModuleMapsNode<ModuleMapsCompositeNode>>? children = null)
        : base(parent, index, textIndex, lengthInParent, children)
    { }

    protected ModuleMapsCompositeNode(IEditableBuffer buffer,
        IEnumerable<IModuleMapsNode<ModuleMapsCompositeNode>> children)
        : base(buffer, children)
    { }
}