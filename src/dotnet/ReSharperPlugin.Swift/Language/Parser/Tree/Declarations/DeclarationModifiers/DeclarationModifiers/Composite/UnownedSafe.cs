using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers.Composite;

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