using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens;
using ReSharperPlugin.Swift.Language.Parser.Tree.Declarations.Constants;

namespace ReSharperPlugin.Swift.Language.Parser.Tree.NodeTypes.Keywords.Declarations;

public class LetNodeType : DeclarationNodeType
{
    internal LetNodeType()
        : base(SwiftTokens.LetId, SwiftTokens.LetIndex)
    { }

    public override LeafElementBase Create(IEditableBuffer buffer, TreeOffset startOffset, TreeOffset endOffset)
    {
        return Let.Create();
    }
}