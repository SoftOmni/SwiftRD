using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Identifiers;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Identifiers;

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