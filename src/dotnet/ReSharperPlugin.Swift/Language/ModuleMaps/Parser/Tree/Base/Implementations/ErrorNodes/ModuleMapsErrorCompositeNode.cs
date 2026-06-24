using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.Root;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.ErrorNodes;

public abstract class ModuleMapsErrorCompositeNode : ModuleMapsErrorInternalNode<ModuleMapsCompositeNode>
{
    protected ModuleMapsErrorCompositeNode(IEditableBuffer buffer, string message)
        : base(buffer, message)
    { }

    protected ModuleMapsErrorCompositeNode(ModuleMapsCompositeNode parent, int index, IEditableBuffer editableBuffer, string message, IEnumerable<IModuleMapsNode<ModuleMapsCompositeNode>>? children = null)
        : base(parent, index, editableBuffer, message, children)
    { }

    protected ModuleMapsErrorCompositeNode(ModuleMapsCompositeNode parent, int index, int textIndex, int lengthInParent, string message, IEnumerable<IModuleMapsNode<ModuleMapsCompositeNode>>? children = null)
        : base(parent, index, textIndex, lengthInParent, message, children)
    { }

    protected ModuleMapsErrorCompositeNode(IEditableBuffer buffer, IEnumerable<IModuleMapsNode<ModuleMapsCompositeNode>?> children,
        string message)
        : base(buffer, FilterOutNullChildren(children), message)
    { }

    private static IEnumerable<IModuleMapsNode<ModuleMapsCompositeNode>> FilterOutNullChildren(
        IEnumerable<IModuleMapsNode<ModuleMapsCompositeNode>?> children)
    {
        List<IModuleMapsNode<ModuleMapsCompositeNode>> list = [];

        foreach (IModuleMapsNode<ModuleMapsCompositeNode>? child in children)
        {
            if (child is not null)
            {
                list.Add(child);
            }
        }

        return list;
    }
}