using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols.Members;

public class SubscriptDeclaration : ProtocolMember
{
    public AttributeGroup? ArgumentAttributes { get; internal set; }
    
    public DeclarationModifierGroup? DeclarationModifierGroup { get; internal set; }
    
    public SubscriptKeyword? SubscriptKeyword { get; internal set; }
    
    public GenericParameterClause? GenericParameterClause { get; internal set; }
    
    public ParameterClause? ParameterClause { get; internal set; }
    
    public SubscriptDeclaration(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SubscriptDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public SubscriptDeclaration(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public SubscriptDeclaration(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}