using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

public abstract class MutationModifier : DeclarationModifierLeaf
{
    public MutationModifier(IEditableBuffer buffer, NodeType nodeType) 
        : base(nodeType, buffer)
    { }

    public MutationModifier(SwiftInternalNode parent, IEditableBuffer buffer, NodeType nodeType) 
        : base(parent, buffer, nodeType)
    { }
}