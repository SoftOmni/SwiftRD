using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;

public class LeafAccessLevelModifier : DeclarationModifierLeaf, IAccessLevelModifier
{
    public LeafAccessLevelModifier(IEditableBuffer buffer, NodeType nodeType) 
        : base(buffer, nodeType)
    { }

    public LeafAccessLevelModifier(SwiftInternalNode parent, IEditableBuffer buffer, NodeType nodeType) 
        : base(parent, buffer, nodeType)
    { }
}