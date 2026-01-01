using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Base.InternalNode;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions.ParameterClauses;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Subscripts;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.ParameterClauses;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Protocols.Members;

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