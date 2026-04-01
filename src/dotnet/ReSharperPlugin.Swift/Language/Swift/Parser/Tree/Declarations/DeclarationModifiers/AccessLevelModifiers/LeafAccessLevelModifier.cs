using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;

public class LeafAccessLevelModifier : DeclarationModifierLeaf, IAccessLevelModifier
{
    public LeafAccessLevelModifier(IEditableBuffer buffer, NodeType nodeType) 
        : base(nodeType, buffer)
    { }

    public LeafAccessLevelModifier(SwiftInternalNode parent, IEditableBuffer buffer, NodeType nodeType) 
        : base(parent, buffer, nodeType)
    { }
}