using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ArgumentClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

public class TypeIdentifierComponent : SwiftInternalNode
{
    public Identifier? Identifier { get; internal set; }
    
    public GenericArgumentClause? GenericArgumentClause { get; internal set; }

    public TypeIdentifierComponent(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeIdentifierComponent(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public TypeIdentifierComponent(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public TypeIdentifierComponent(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}