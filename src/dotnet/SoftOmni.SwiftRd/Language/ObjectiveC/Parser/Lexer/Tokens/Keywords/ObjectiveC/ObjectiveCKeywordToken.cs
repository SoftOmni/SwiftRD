using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Tree.Keywords;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Keywords.ObjectiveC;

public abstract class ObjectiveCKeywordToken<TAstLeafNode>(string keywordValue, int index)
    : KeywordToken<TAstLeafNode>(keywordValue, index)
    where TAstLeafNode : LeafElementBase, IObjectiveCKeyword, new()
{
    public override bool IsStandardCKeyword => true;

    public override bool IsObjectiveCKeyword => false;
}
