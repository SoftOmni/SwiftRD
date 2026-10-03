using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords;

public abstract class KeywordToken : ObjectiveCTokenNodeType
{
    public abstract bool IsStandardCKeyword { get; }
    
    public abstract bool IsObjectiveCKeyword { get; }
    
    protected KeywordToken(string keywordValue, int index)
        : base(keywordValue, index)
    {
        TokenRepresentation = keywordValue;
    }

    public override string TokenRepresentation { get; }
}

public abstract class KeywordToken<TAstLeafNode>(string keywordValue, int index)
    : KeywordToken(keywordValue, index)
    where TAstLeafNode : LeafElementBase, IObjectiveCKeyword, new()
{
    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        CheckAgainstValue(TokenRepresentation, buffer, Name);
        return new TAstLeafNode();
    }
}
