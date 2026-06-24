using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

public class InfixOperatorDeclaration : OperatorDeclaration
{
    public Infix? Infix { get; internal set; }
    
    public Colon? Colon { get; internal set; }
    
    public Identifier? PrecedenceGroupIdentifier { get; internal set; }
    
    public InfixOperatorDeclaration(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public InfixOperatorDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public InfixOperatorDeclaration(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public InfixOperatorDeclaration(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}