using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.ParameterClauses;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.WhereClauses;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types.TypeInheritanceClauses;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Actors;

public class Actor : Declaration
{
    public AttributeGroup? AttributeGroup { get; internal set; }
    
    public IAccessLevelModifier? AccessLevelModifier { get; internal set; }
    
    public ActorKeyword? ActorKeyword { get; internal set; }
    
    public Identifier? Identifier { get; internal set; }
    
    public GenericParameterClause? GenericParameterClause { get; internal set; }
    
    public TypeInheritanceClause? TypeInheritanceClause { get; internal set; }
    
    public GenericWhereClause? GenericWhereClause { get; internal set; }
    
    public LeftCurlyBrace? LeftCurlyBrace { get; internal set; }
    
    public ActorMemberGroup? ActorMemberGroup { get; internal set; }
    
    public RightCurlyBrace? RightCurlyBrace { get; internal set; }
    
    public Actor(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Actor(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Actor(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public Actor(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}