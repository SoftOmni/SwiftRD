using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Tree.Attributes;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.DeclarationModifiers;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Functions.ParameterClauses;
using ReSharperPlugin.Swift.Language.Parser.Tree.Expressions;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.ParameterClauses;
using ReSharperPlugin.Swift.Language.Parser.Tree.Generics.WhereClauses;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;
using ReSharperPlugin.Swift.Language.Parser.Tree.Types;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Macros;

public class Macro : Declaration
{
    public AttributeGroup? AttributeGroup { get; internal set; }
    
    public DeclarationModifierGroup? DeclarationModifierGroup { get; internal set; }
    
    public MacroKeyword? MacroKeyword { get; internal set; }
    
    public GenericParameterClause? GenericParameterClause { get; internal set; }
    
    public ParameterClause? ParameterClause { get; internal set; }
    
    public Arrow? Arrow { get; internal set; }
    
    public IType? Type { get; internal set; }
    
    public Equal? Equal { get; internal set; }
    
    public Expression? Expression { get; internal set; }
    
    public GenericWhereClause? GenericWhereClause { get; internal set; }
    
    public Macro(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public Macro(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public Macro(ISwiftNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public Macro(ISwiftNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}