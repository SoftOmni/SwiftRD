using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

public class UnownedUnsafe : DeclarationModifierInternal
{
    public Unowned? Unowned { get; private set; }

    public LeftParenthesis? LeftParenthesis { get; private set; }

    public Unsafe? Unsafe { get; private set; }

    public RightParenthesis? RightParenthesis { get; private set; }

    public UnownedUnsafe(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public UnownedUnsafe(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public UnownedUnsafe(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public UnownedUnsafe(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}