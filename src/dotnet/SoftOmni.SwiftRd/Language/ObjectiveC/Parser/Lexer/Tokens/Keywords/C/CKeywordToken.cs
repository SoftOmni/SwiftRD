using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.C;

public abstract class CKeywordToken<TAstLeafNode>(string keywordValue, int index)
    : KeywordToken<TAstLeafNode>(keywordValue, index)
    where TAstLeafNode : LeafElementBase, IObjectiveCKeyword, new()
{
    public override bool IsStandardCKeyword => true;

    public override bool IsObjectiveCKeyword => false;
}

public abstract class C11KeywordToken<TAstLeafNode>(string keywordValue, int index)
    : CKeywordToken<TAstLeafNode>(keywordValue, index)
    where TAstLeafNode : LeafElementBase, IObjectiveCKeyword, new()
{
    public override bool IsStandardCKeyword => true;

    public override bool IsObjectiveCKeyword => false;
}
