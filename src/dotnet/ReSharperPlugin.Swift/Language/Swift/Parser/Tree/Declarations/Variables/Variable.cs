using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Blocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Clauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.SetterSetterBlocks.Clauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;

public class Variable : Declaration
{
    public List<Attribute> Attributes { get; private set; } = [];

    public DeclarationModifierGroup? DeclarationModifiers { get; private set; }
    
    public Var? Var { get; private set; }

    public List<PatternInitializer> PatternInitializers { get; private set; } = [];
    
    public Identifier? Name { get; private set; }
    
    public TypeAnnotation? TypeAnnotation { get; private set; }
    
    public Expression? Initializer { get; private set; }
    
    public GetterSetterBlock<GetterClause, SetterClause>? GetterSetterBlock { get; private set; }
    
    public WillSetDidSetBlock? WillSetDidSetBlock { get; private set; }

    public Variable(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Variable(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Variable(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public Variable(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}