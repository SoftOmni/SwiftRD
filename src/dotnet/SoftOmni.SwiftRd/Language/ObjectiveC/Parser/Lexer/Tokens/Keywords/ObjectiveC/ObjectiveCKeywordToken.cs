using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public abstract class ObjectiveCKeywordToken(string keywordValue, int index)
    : KeywordToken(keywordValue, index)
{
    public override bool IsStandardCKeyword => true;

    public override bool IsObjectiveCKeyword => false;
}

public abstract class ObjectiveCKeywordToken<TAstLeafNode>(string keywordValue, int index)
    : ObjectiveCKeywordToken(keywordValue, index)
    where TAstLeafNode : LeafElementBase, IObjectiveCKeyword, new()
{
    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        CheckAgainstValue(TokenRepresentation, buffer, Name);
        return new TAstLeafNode();
    }
}
