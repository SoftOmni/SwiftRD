using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Keywords;

public abstract class SwiftKeywordToken<AstLeafNode>(string value, string tokenId, int index) : SwiftTokenNodeType(tokenId, index) 
    where AstLeafNode : LeafElementBase, ISwiftKeywordNode<AstLeafNode>, new()
{
    public override string TokenRepresentation { get; } = value;

    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        CheckAgainstValue(TokenRepresentation, buffer, Name);
        return new AstLeafNode();
    }

    public override bool IsKeyword => true;

    public virtual bool ParameterUsable => false;
    
    public virtual bool DeclarationUsable => false;
    
    public virtual bool StatementUsable => false;
    
    public virtual bool PatternUsable => false;
    
    public virtual bool ContentSensitive => false;
    
    public virtual bool ReservedIdentifier => false;
    
    public virtual Version? Availability => null;
    
    public virtual Version? RemovalVersion => null;
}
