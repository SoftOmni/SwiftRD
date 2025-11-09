using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers.DeclarationModifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Classes;

public class Class : Declaration
{
    public AttributeGroup? AttributeGroup { get; internal set; }
    
    public IAccessLevelModifier? AccessLevelModifier { get; internal set; }
    
    public Final? Final { get; internal set; }
    
    public DeclarationModifiers.DeclarationModifiers.Class? ClassKeyword { get; internal set; }
    
    public Identifier? Identifier { get; internal set; }
    
    public LeftCurlyBrace? LeftCurlyBrace { get; internal set; }
    
    public RightCurlyBrace? RightCurlyBrace { get; internal set; }
    
    public ClassMemberGroup? ClassMemberGroup { get; internal set; }
    
    public Class(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Class(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Class(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public Class(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}