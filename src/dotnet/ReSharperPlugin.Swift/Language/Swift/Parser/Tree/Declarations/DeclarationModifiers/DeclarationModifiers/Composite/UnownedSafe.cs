using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

public class UnownedSafe : DeclarationModifierInternal
{
    public Unowned? Unowned { get; private set; }
    
    public LeftParenthesis? LeftParenthesis { get; private set; }
    
    public Safe? Safe { get; private set; }
    
    public RightParenthesis? RightParenthesis { get; private set; }
    
    public UnownedSafe(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public UnownedSafe(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public UnownedSafe(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public UnownedSafe(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}