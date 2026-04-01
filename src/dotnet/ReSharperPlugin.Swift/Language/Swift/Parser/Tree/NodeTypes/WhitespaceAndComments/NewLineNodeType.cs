using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.NodeTypes.WhitespaceAndComments;

public class NewLineNodeType : SwiftNodeType
{
    internal NewLineNodeType() : base(SwiftTokens.NewlineId, SwiftTokens.NewlineIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return new NewLine(buffer);
    }

    public override bool IsWhitespace => true;

    public override bool IsComment => false;

    public override bool IsStringLiteral => false;

    public override bool IsConstantLiteral => false;

    public override bool IsIdentifier => false;

    public override bool IsKeyword => false;
    
    public override string TokenRepresentation => SwiftTokens.NewlineId;
}