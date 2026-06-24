using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators;

public class PrefixOperatorDeclaration : OperatorDeclaration
{
    public Prefix? Prefix { get; internal set; }
    
    public PrefixOperatorDeclaration(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrefixOperatorDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public PrefixOperatorDeclaration(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public PrefixOperatorDeclaration(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}