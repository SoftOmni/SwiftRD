using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers;

public abstract class DeclarationModifierLeaf : SwiftLeafNode, IDeclarationModifier
{
    public DeclarationModifierLeaf(IEditableBuffer buffer, NodeType nodeType) 
        : base(buffer, nodeType)
    { }

    public DeclarationModifierLeaf(ISwiftNode parent, IEditableBuffer buffer, NodeType nodeType) 
        : base(parent, buffer, nodeType)
    { }
}