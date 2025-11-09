using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Punctuators;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Punctuators;

public class LeftCurlyBraceNodeType : PunctuatorNodeType
{
    internal LeftCurlyBraceNodeType()
        : base(SwiftTokens.LeftCurlyBraceId, SwiftTokens.LeftAngleBracketIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return LeftCurlyBrace.Create();
    }
}