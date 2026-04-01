using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.ParameterClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols.Members;

public class InitializerDeclaration : ProtocolMember
{
    public AttributeGroup? AttributeGroup { get; internal set; }
    
    public DeclarationModifierGroup? DeclarationModifierGroup { get; internal set; }
    
    public Init? Init { get; internal set; }
    
    public QuestionMark? QuestionMark { get; internal set; }
    
    public ExclamationMark? ExclamationMark { get; internal set; }
    
    public GenericParameterClause? GenericParameterClause { get; internal set; }
    
    public ParameterClause? ParameterClause { get; internal set; }
    
    public ThrowsClause? ThrowsClause { get; internal set; }
    
    public Rethrows? Rethrows { get; internal set; }
    
    public GenericWhereClause? GenericWhereClause { get; internal set; }

    public InitializerDeclaration(IEditableBuffer buffer, List<ISwiftNode> children)
        : base(buffer, children)
    { }

    public InitializerDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode> children)
        : base(buffer, children)
    { }

    public InitializerDeclaration(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }

    public InitializerDeclaration(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes)
        : base(parent, buffer, nodes)
    { }
}