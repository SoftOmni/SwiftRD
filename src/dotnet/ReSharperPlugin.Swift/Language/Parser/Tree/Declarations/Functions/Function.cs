using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.CodeBlocks;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.ParameterClauses;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.WhereClauses;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions;

public class Function : Declaration
{
    public AttributeGroup? Attributes { get; private set; }
    
    public DeclarationModifierGroup? DeclarationModifiers { get; private set; }
    
    public Func? Func { get; private set; }
    
    public FunctionName? FunctionName { get; private set; }
    
    public GenericParameterClause? GenericParameterClause { get; private set; }
    
    public FunctionSignature? FunctionSignature { get; private set; }
    
    public GenericWhereClause? GenericWhereClause { get; private set; }
    
    public CodeBlock? FunctionBody { get; private set; }
    
    public Function(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Function(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Function(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public Function(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}