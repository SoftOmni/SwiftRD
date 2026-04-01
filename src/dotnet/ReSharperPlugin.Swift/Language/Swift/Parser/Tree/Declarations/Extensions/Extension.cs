using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeIdentifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Extensions;

public class Extension : Declaration
{
    public AttributeGroup? AttributeGroup { get; internal set; }
    
    public IAccessLevelModifier? AccessLevelModifier { get; internal set; }
    
    public ExtensionKeyword? ExtensionKeyword { get; internal set; }
    
    public TypeIdentifier? TypeIdentifier { get; internal set; }
    
    public GenericWhereClause? GenericWhereClause { get; internal set; }
    
    public LeftCurlyBrace? LeftCurlyBrace { get; internal set; }
    
    public ExtensionMemberGroup? ExtensionMemberGroup { get; internal set; }
    
    public RightCurlyBrace? RightCurlyBrace { get; internal set; }

    public Extension(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Extension(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Extension(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public Extension(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}