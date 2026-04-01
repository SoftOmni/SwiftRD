using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.LeafNodes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;

public abstract class DeclarationModifierLeaf : SwiftLeafNode<SwiftCompositeNode>, IDeclarationModifier
{
    protected DeclarationModifierLeaf(IEditableBuffer buffer) 
        : base(buffer)
    { }

    protected DeclarationModifierLeaf(IEditableBuffer buffer, SwiftCompositeNode parent, int parentIndex, int parentTextIndex) 
        : base(buffer, parent, parentIndex, parentTextIndex)
    { }
}