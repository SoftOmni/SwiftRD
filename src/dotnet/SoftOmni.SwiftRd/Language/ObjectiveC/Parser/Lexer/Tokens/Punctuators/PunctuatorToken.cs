using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Punctuators;

public abstract class PunctuatorToken : ObjectiveCTokenNodeType
{
    protected PunctuatorToken(string punctuator, string tokenId, int index)
        : base(tokenId, index)
    {
        TokenRepresentation = punctuator;
    }

    public override string TokenRepresentation { get; }
}

public abstract class PunctuatorToken<TAstLeafNode>(string tokenValue, int index)
    : PunctuatorToken(tokenValue, tokenValue, index)
    where TAstLeafNode : LeafElementBase, IObjectiveCPunctuator, new()
{
    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        CheckAgainstValue(TokenRepresentation, buffer, Name);
        return new TAstLeafNode();
    }
}
