using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeclarationModifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.Blocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Protocols.Members;

public class PropertyDeclaration : ProtocolMember
{
    public List<Attribute> Attributes { get; private set; } = [];

    public DeclarationModifierGroup? DeclarationModifiers { get; private set; }
    
    public Var? Var { get; private set; }
    
    public Identifier? Identifier { get; internal set; }
    
    public TypeAnnotation? TypeAnnotation { get; internal set; }
    
    public KeywordGetterSetterBlock? KeywordGetterSetterBlock { get; internal set; }
    
    public PropertyDeclaration(IEditableBuffer buffer, List<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public PropertyDeclaration(IEditableBuffer buffer, IEnumerable<ISwiftNode> children) 
        : base(buffer, children)
    { }

    public PropertyDeclaration(SwiftInternalNode parent, IEditableBuffer buffer, List<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }

    public PropertyDeclaration(SwiftInternalNode parent, IEditableBuffer buffer, IEnumerable<ISwiftNode> nodes) 
        : base(parent, buffer, nodes)
    { }
}