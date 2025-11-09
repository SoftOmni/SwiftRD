using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.ParameterClauses;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.WhereClauses;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Protocols.Members;

public class MethodDeclaration : ProtocolMember
{
    public AttributeGroup? AttributeGroup { get; internal set; }
    
    public DeclarationModifierGroup? DeclarationModifierGroup { get; internal set; }
    
    public Func? Func { get; internal set; }
    
    public Identifier? Identifier { get; internal set; }
    
    public GenericParameterClause? GenericParameterClause { get; internal set; }
    
    public FunctionSignature? FunctionSignature { get; internal set; }
    
    public GenericWhereClause? GenericWhereClause { get; internal set; }

    public MethodDeclaration(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public MethodDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public MethodDeclaration(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public MethodDeclaration(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}