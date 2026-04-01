using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Identifiers;

public class IdentifierNodeType : SwiftNodeType
{
    internal IdentifierNodeType()
        : base(SwiftTokens.IdentifierId, SwiftTokens.IdentifierIndex)
    { }
    
    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return new Identifier(buffer);
    }

    public override bool IsWhitespace => false;

    public override bool IsComment => false;

    public override bool IsStringLiteral => false;

    public override bool IsConstantLiteral => false;
    
    public override bool IsIdentifier => true;

    public override bool IsKeyword => false;
}