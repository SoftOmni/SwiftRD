using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public abstract class CKeywordToken(string keywordValue, int index)
    : KeywordToken(keywordValue, index)
{
    public override bool IsStandardCKeyword => true;

    public override bool IsObjectiveCKeyword => false;
}

public abstract class CKeywordToken<TAstLeafNode>(string keywordValue, int index)
    : CKeywordToken(keywordValue, index)
    where TAstLeafNode : LeafElementBase, IObjectiveCKeyword, new()
{
    public override LeafElementBase Create(IBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        CheckAgainstValue(TokenRepresentation, buffer, Name);
        return new TAstLeafNode();
    }
}

public abstract class C11KeywordToken<TAstLeafNode>(string keywordValue, int index)
    : CKeywordToken<TAstLeafNode>(keywordValue, index)
    where TAstLeafNode : LeafElementBase, IObjectiveCKeyword, new()
{
    public override bool IsStandardCKeyword => true;

    public override bool IsObjectiveCKeyword => false;
}
