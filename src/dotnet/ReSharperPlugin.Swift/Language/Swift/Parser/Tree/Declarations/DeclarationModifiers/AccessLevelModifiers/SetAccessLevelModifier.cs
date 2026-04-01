using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;

public abstract class SetAccessLevelModifier : DeclarationModifierInternal, IAccessLevelModifier
{
    public LeafAccessLevelModifier? AccessLevelModifier { get; private set; }

    public LeftParenthesis? LeftParenthesis { get; private set; }

    public Set? Set { get; private set; }

    public RightParenthesis? RightParenthesis { get; private set; }

    protected SetAccessLevelModifier(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected SetAccessLevelModifier(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected SetAccessLevelModifier(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    protected SetAccessLevelModifier(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}