using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.Patterns;

public class UnderscoreNodeType : SwiftNodeType
{
    internal UnderscoreNodeType() : base(SwiftTokens.UnderscoreId, SwiftTokens.UnderscoreIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        throw new System.NotImplementedException();
    }

    public override bool IsWhitespace => false;

    public override bool IsComment => false;

    public override bool IsStringLiteral => false;

    public override bool IsConstantLiteral => false;

    public override bool IsIdentifier => false;

    public override bool IsKeyword => false;
}