using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

public abstract class Subscript : Declaration
{
    public AttributeGroup? ArgumentAttributes { get; internal set; }
    
    public DeclarationModifierGroup? DeclarationModifierGroup { get; internal set; }
    
    public SubscriptKeyword? SubscriptKeyword { get; internal set; }
    
    public GenericParameterClause? GenericParameterClause { get; internal set; }
    
    public ParameterClause? ParameterClause { get; internal set; }
    
    public GenericWhereClause? GenericWhereClause { get; internal set;  }
    
    public Arrow? Arrow { get; internal set; }
    
    public AttributeGroup? ReturnTypeAttributes { get; internal set; }
    
    public IType? ReturnType { get; internal set; }
    
    protected Subscript(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected Subscript(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    protected Subscript(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    protected Subscript(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}