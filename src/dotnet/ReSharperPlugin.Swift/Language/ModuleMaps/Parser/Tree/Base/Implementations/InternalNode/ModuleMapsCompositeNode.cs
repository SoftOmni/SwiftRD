using System.Collections.Generic;
using JetBrains.Text;
using ReSharperPlugin.Swift.Language.Swift.Parser.Tree.Comments.Errors;
using SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.WhitespaceAndComments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Comments;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Whitespace;
using SoftOmni.SwiftRd.Technology;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.Parser.Tree.Base.Implementations.InternalNodes;

public abstract class ModuleMapsCompositeNode : ModuleMapsInternalNode<ModuleMapsCompositeNode>
{
    protected ModuleMapsCompositeNode(IEditableBuffer buffer)
        : base(buffer)
    { }

    protected ModuleMapsCompositeNode(ModuleMapsCompositeNode parent, int index, IEditableBuffer editableBuffer,
        IEnumerable<IModuleMapsNode<ModuleMapsCompositeNode>>? children = null)
        : base(parent, index, editableBuffer, children)
    { }

    protected ModuleMapsCompositeNode(ModuleMapsCompositeNode parent, int index, int textIndex, int lengthInParent,
        IEnumerable<IModuleMapsNode<ModuleMapsCompositeNode>>? children = null)
        : base(parent, index, textIndex, lengthInParent, children)
    { }

    protected ModuleMapsCompositeNode(IEditableBuffer buffer,
        IEnumerable<IModuleMapsNode<ModuleMapsCompositeNode>> children)
        : base(buffer, children)
    { }

    protected static int AdvanceAndAddCommentsWhitespace(IEditableBuffer buffer, int currentOffset, List<IModuleMapsNode<ModuleMapsCompositeNode>> children,
        SwiftLexer lexer)
    {
        lexer.Advance();

        while (lexer.TokenType is not null && (lexer.TokenType.IsComment || lexer.TokenType.IsWhitespace) && lexer.TokenType is not EndOfFileToken)
        {
            SubEditableBuffer subBuffer = new(buffer, currentOffset, lexer.TokenLength);
            currentOffset += lexer.TokenLength;
            if (lexer.TokenType.IsWhitespace)
            {
                WhitespaceSequence whitespaceSequence = new(subBuffer);
                children.Add(whitespaceSequence);
                currentOffset += lexer.TokenLength;

                continue;
            }

            if (!lexer.TokenType.IsComment)
            {
                UnexpectedParserStateNode unexpectedParserStateNode = new(subBuffer, lexer.TokenType);
                children.Add(unexpectedParserStateNode);
                currentOffset += lexer.TokenLength;

                continue;
            }

            if (lexer.TokenType is LineCommentToken)
            {
                LineCommentNode lineComment = new(subBuffer);
                children.Add(lineComment); // TODO: modify parent
                currentOffset += lexer.TokenLength;

                continue;
            }

            if (lexer.TokenType is BlockCommentStartToken)
            {
                BlockCommentNode commentNode = BlockCommentNode.ParseWithStart(lexer, subBuffer, currentOffset, 1);
                children.Add(commentNode);
                currentOffset += commentNode.GetTextLength();

                continue;
            }

            if (lexer.TokenType is BlockCommentContentToken or BlockCommentEndToken)
            {
                ImpossibleLexerCommentToken impossibleLexerCommentToken = new(subBuffer, lexer.TokenType);
                children.Add(impossibleLexerCommentToken);
                currentOffset += lexer.TokenLength;

                continue;
            }

            UnknownCommentTokenNode unknownCommentToken = new(subBuffer, lexer.TokenType);
            children.Add(unknownCommentToken);
            currentOffset += lexer.TokenLength;
        }

        return currentOffset;
    }
}