using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Keywords;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.CompilerControlStatements.ConditionalCompilationBlock.CompilationConditions.PlatformConditions;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Reserved;

public abstract class PreviouslyReservedKeywordToken<AstLeafNode>(string value, string tokenId, int index)
    : SwiftKeywordToken<AstLeafNode>(value, tokenId, index)
    where AstLeafNode : LeafElementBase, ISwiftKeywordNode<AstLeafNode>, new()
{
    public abstract override ISwiftVersion RemovalVersion { get; }
}
