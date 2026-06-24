using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Base.Implementations.Constrained.Concretely.Root;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.LeafNodes;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.NodeTypes;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.Root;

public class ModuleMapsRootNode<TSelf> : RootNode<IModuleMapsNodeFamily<TSelf>, TSelf, ModuleMapsLeafNode<TSelf>>, IModuleMapsInternalNode<TSelf>
    where TSelf : ModuleMapsRootNode<TSelf>
{
    protected ModuleMapsRootNode(IEditableBuffer buffer)
        : base(buffer)
    {
        
    }

    public override NodeType NodeType => ModuleMapsNodeTypes.File;

    public override PsiLanguageType Language => ModuleMapsLanguage.Instance!;
}