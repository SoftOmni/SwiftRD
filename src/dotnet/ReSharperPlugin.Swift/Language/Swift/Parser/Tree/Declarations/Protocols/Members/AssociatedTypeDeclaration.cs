using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols.Members;

public class AssociatedTypeDeclaration : ProtocolMember
{
    public AttributeGroup? Attributes { get; internal set; }
    
    public IAccessLevelModifier? AccessLevelModifier { get; internal set; }
    
    public AssociatedType? AssociatedType { get; internal set; }
    
    public Identifier? Name { get; internal set; }
    
    public TypeInheritanceClause? TypeInheritanceClause { get; internal set; }
    
    public Equal? Equal { get; internal set; }
    
    public IType? Type { get; internal set; }
    
    public GenericWhereClause? GenericWhereClause { get; internal set; }
    
    public AssociatedTypeDeclaration(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public AssociatedTypeDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public AssociatedTypeDeclaration(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public AssociatedTypeDeclaration(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}