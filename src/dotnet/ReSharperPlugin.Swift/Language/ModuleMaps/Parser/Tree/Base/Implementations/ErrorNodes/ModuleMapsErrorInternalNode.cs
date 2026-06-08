using System.Collections.Generic;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Concretely.ErrorNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.ErrorNodes;

public class ModuleMapsErrorInternalNode<TSelf> : ErrorInternalNode<IModuleMapsNodeFamily<TSelf>, TSelf, ModuleMapsLeafNode<TSelf>>, IModuleMapsInternalNode<TSelf>
    where TSelf : ModuleMapsInternalNode<TSelf>
{
    protected ModuleMapsErrorInternalNode(IEditableBuffer buffer, string message)
        : base(buffer, message)
    { }

    protected ModuleMapsErrorInternalNode(TSelf parent, int index, IEditableBuffer editableBuffer, string message, IEnumerable<ISwiftNode<TSelf>>? children = null)
        : base(parent, index, editableBuffer, children, message)
    { }

    protected ModuleMapsErrorInternalNode(TSelf parent, int index, int textIndex, int lengthInParent, string message, IEnumerable<ISwiftNode<TSelf>>? children = null)
        : base(parent, index, textIndex, lengthInParent, children, message)
    { }

    protected ModuleMapsErrorInternalNode(IEditableBuffer buffer, IEnumerable<ISwiftNode<TSelf>> children, string message)
        : base(buffer, children, message)
    { }

    public override PsiLanguageType Language => SwiftLanguage.Instance!;

    public override NodeType NodeType => SwiftNodeTypes.Internal;
}