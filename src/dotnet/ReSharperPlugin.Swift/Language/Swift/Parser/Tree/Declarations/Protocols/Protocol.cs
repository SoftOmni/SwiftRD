using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers.AccessLevelModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Generics.WhereClauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeInheritanceClauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols;

public class Protocol : Declaration
{
    public AttributeGroup? AttributeGroup { get; internal set; }
    
    public IAccessLevelModifier? AccessLevelModifier { get; internal set; }
    
    public ProtocolLowercase? ProtocolKeyword { get; internal set; }
    
    public TypeInheritanceClause? TypeInheritanceClause { get; internal set; }
    
    public GenericWhereClause? GenericWhereClause { get; internal set; }
    
    public LeftCurlyBrace? LeftCurlyBrace { get; internal set; }
    
    public ProtocolMemberGroup? ProtocolMemberGroup { get; internal set; }
    
    public RightCurlyBrace? RightCurlyBrace { get; internal set; }
    
    public Protocol(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Protocol(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public Protocol(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public Protocol(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}