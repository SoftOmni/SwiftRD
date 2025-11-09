using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.MutationModifiers;

public abstract class MutationModifier : DeclarationModifierLeaf
{
    public MutationModifier(IEditableBuffer buffer, NodeType nodeType) 
        : base(buffer, nodeType)
    { }

    public MutationModifier(ISwiftNode parent, IEditableBuffer buffer, NodeType nodeType) 
        : base(parent, buffer, nodeType)
    { }
}