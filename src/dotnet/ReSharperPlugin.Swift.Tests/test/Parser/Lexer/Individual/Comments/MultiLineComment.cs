using System.Text;
using JetBrains.Text;
using NUnit.Framework;
using ReSharperPlugin.Swift.Extensions;
using ReSharperPlugin.Swift.Language.Parser.Lexer;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Markers;
using ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.WhitespaceAndComments;

namespace ReSharperPlugin.Swift.Tests.test.Parser.Lexer.Individual.Comments;

[TestFixture]
public class MultiLineComment
{
    [Test]
    public void Empty()
    {
        const string content = "/**/";
        IBuffer code = new StringBuilderBuffer(new StringBuilder(content));
        SwiftLexer lexer = new(code);
        
        // Does the base case work?
        LexerBaseCase.AssessBaseCaseForLexer(lexer, content);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(0, lexer.TokenStart);
        Assert.AreEqual(2, lexer.TokenEnd);
        Assert.AreEqual(1, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.False(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(0, lexer.CommentLevel);
        Assert.AreEqual(2, lexer.TokenStart);
        Assert.AreEqual(content.Length, lexer.TokenEnd);
        Assert.AreEqual(2, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentEndToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
        
        lexer.Advance();

        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
    }
    
    [Test]
    public void EmptyRecursive()
    {
        const string content = "/*/*/**/*/*/";
        IBuffer code = new StringBuilderBuffer(new StringBuilder(content));
        SwiftLexer lexer = new(code);
        
        // Does the base case work?
        LexerBaseCase.AssessBaseCaseForLexer(lexer, content);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(0, lexer.TokenStart);
        Assert.AreEqual(2, lexer.TokenEnd);
        Assert.AreEqual(1, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(2, lexer.CommentLevel);
        Assert.AreEqual(2, lexer.TokenStart);
        Assert.AreEqual(4, lexer.TokenEnd);
        Assert.AreEqual(2, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(3, lexer.CommentLevel);
        Assert.AreEqual(4, lexer.TokenStart);
        Assert.AreEqual(6, lexer.TokenEnd);
        Assert.AreEqual(3, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(2, lexer.CommentLevel);
        Assert.AreEqual(6, lexer.TokenStart);
        Assert.AreEqual(8, lexer.TokenEnd);
        Assert.AreEqual(4, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentEndToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(8, lexer.TokenStart);
        Assert.AreEqual(10, lexer.TokenEnd);
        Assert.AreEqual(5, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentEndToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.False(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(0, lexer.CommentLevel);
        Assert.AreEqual(10, lexer.TokenStart);
        Assert.AreEqual(content.Length, lexer.TokenEnd);
        Assert.AreEqual(6, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentEndToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
        
        lexer.Advance();

        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
    }
    
    [Test]
    public void EmptyRecursiveUnbalancedOpening()
    {
        const string content = "/*/*/**/*/";
        IBuffer code = new StringBuilderBuffer(new StringBuilder(content));
        SwiftLexer lexer = new(code);
        
        // Does the base case work?
        LexerBaseCase.AssessBaseCaseForLexer(lexer, content);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(0, lexer.TokenStart);
        Assert.AreEqual(2, lexer.TokenEnd);
        Assert.AreEqual(1, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(2, lexer.CommentLevel);
        Assert.AreEqual(2, lexer.TokenStart);
        Assert.AreEqual(4, lexer.TokenEnd);
        Assert.AreEqual(2, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(3, lexer.CommentLevel);
        Assert.AreEqual(4, lexer.TokenStart);
        Assert.AreEqual(6, lexer.TokenEnd);
        Assert.AreEqual(3, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(2, lexer.CommentLevel);
        Assert.AreEqual(6, lexer.TokenStart);
        Assert.AreEqual(8, lexer.TokenEnd);
        Assert.AreEqual(4, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentEndToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(8, lexer.TokenStart);
        Assert.AreEqual(content.Length, lexer.TokenEnd);
        Assert.AreEqual(5, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentEndToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(content.Length, lexer.TokenStart);
        Assert.AreEqual(content.Length, lexer.TokenEnd);
        Assert.AreEqual(5, lexer.TokenCount);
        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
    }
    
    [Test]
    public void Simple()
    {
        const string content = "/* OpenIntelliJ btw btw */";
        IBuffer code = new StringBuilderBuffer(new StringBuilder(content));
        SwiftLexer lexer = new(code);
        
        // Does the base case work?
        LexerBaseCase.AssessBaseCaseForLexer(lexer, content);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(0, lexer.TokenStart);
        Assert.AreEqual(2, lexer.TokenEnd);
        Assert.AreEqual(1, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(2, lexer.TokenStart);
        Assert.AreEqual(content.Length - 2, lexer.TokenEnd);
        Assert.AreEqual(2, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentContentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.False(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(0, lexer.CommentLevel);
        Assert.AreEqual(content.Length - 2, lexer.TokenStart);
        Assert.AreEqual(content.Length, lexer.TokenEnd);
        Assert.AreEqual(3, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentEndToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
        
        lexer.Advance();

        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
    }
    
    [Test]
    public void MultiMadness()
    {
        const string content = "/* OpenIntelliJ btw btw /* and also SoftOmni btw btw */ */";
        IBuffer code = new StringBuilderBuffer(new StringBuilder(content));
        SwiftLexer lexer = new(code);
        
        // Does the base case work?
        LexerBaseCase.AssessBaseCaseForLexer(lexer, content);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(0, lexer.TokenStart);
        Assert.AreEqual(2, lexer.TokenEnd);
        Assert.AreEqual(1, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(2, lexer.TokenStart);
        Assert.AreEqual(24, lexer.TokenEnd);
        Assert.AreEqual(2, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentContentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(2, lexer.CommentLevel);
        Assert.AreEqual(24, lexer.TokenStart);
        Assert.AreEqual(26, lexer.TokenEnd);
        Assert.AreEqual(3, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(2, lexer.CommentLevel);
        Assert.AreEqual(26, lexer.TokenStart);
        Assert.AreEqual(content.Length - 5, lexer.TokenEnd);
        Assert.AreEqual(4, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentContentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();

        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(content.Length - 5, lexer.TokenStart);
        Assert.AreEqual(content.Length - 3, lexer.TokenEnd);
        Assert.AreEqual(5, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentEndToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();

        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(content.Length - 3, lexer.TokenStart);
        Assert.AreEqual(content.Length - 2, lexer.TokenEnd);
        Assert.AreEqual(6, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentContentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.False(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(0, lexer.CommentLevel);
        Assert.AreEqual(content.Length - 2, lexer.TokenStart);
        Assert.AreEqual(content.Length, lexer.TokenEnd);
        Assert.AreEqual(7, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentEndToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
    }
    
    [Test]
    public void MultiMadnessUnbalanced()
    {
        const string content = "/* OpenIntelliJ btw btw /* and also SoftOmni btw btw */ ";
        IBuffer code = new StringBuilderBuffer(new StringBuilder(content));
        SwiftLexer lexer = new(code);
        
        // Does the base case work?
        LexerBaseCase.AssessBaseCaseForLexer(lexer, content);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(0, lexer.TokenStart);
        Assert.AreEqual(2, lexer.TokenEnd);
        Assert.AreEqual(1, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(2, lexer.TokenStart);
        Assert.AreEqual(24, lexer.TokenEnd);
        Assert.AreEqual(2, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentContentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(2, lexer.CommentLevel);
        Assert.AreEqual(24, lexer.TokenStart);
        Assert.AreEqual(26, lexer.TokenEnd);
        Assert.AreEqual(3, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(2, lexer.CommentLevel);
        Assert.AreEqual(26, lexer.TokenStart);
        Assert.AreEqual(content.Length - 3, lexer.TokenEnd);
        Assert.AreEqual(4, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentContentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();

        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(content.Length - 3, lexer.TokenStart);
        Assert.AreEqual(content.Length - 1, lexer.TokenEnd);
        Assert.AreEqual(5, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentEndToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();

        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(content.Length - 1, lexer.TokenStart);
        Assert.AreEqual(content.Length, lexer.TokenEnd);
        Assert.AreEqual(6, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentContentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
        Assert.AreEqual(1, lexer.LexerStateEx);
    }
    
    [Test]
    public void MultiMadnessSeveralLines()
    {
        const string content = "/* OpenIntelliJ btw btw \n/* \r\nand also SoftOmni btw btw */ */";
        IBuffer code = new StringBuilderBuffer(new StringBuilder(content));
        SwiftLexer lexer = new(code);
        
        // Does the base case work?
        LexerBaseCase.AssessBaseCaseForLexer(lexer, content);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(0, lexer.TokenStart);
        Assert.AreEqual(2, lexer.TokenEnd);
        Assert.AreEqual(1, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(2, lexer.TokenStart);
        Assert.AreEqual(25, lexer.TokenEnd);
        Assert.AreEqual(2, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentContentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(2, lexer.CommentLevel);
        Assert.AreEqual(25, lexer.TokenStart);
        Assert.AreEqual(27, lexer.TokenEnd);
        Assert.AreEqual(3, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentStartToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(2, lexer.CommentLevel);
        Assert.AreEqual(27, lexer.TokenStart);
        Assert.AreEqual(content.Length - 5, lexer.TokenEnd);
        Assert.AreEqual(4, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentContentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();

        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(content.Length - 5, lexer.TokenStart);
        Assert.AreEqual(content.Length - 3, lexer.TokenEnd);
        Assert.AreEqual(5, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentEndToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();

        Assert.True(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(1, lexer.CommentLevel);
        Assert.AreEqual(content.Length - 3, lexer.TokenStart);
        Assert.AreEqual(content.Length - 2, lexer.TokenEnd);
        Assert.AreEqual(6, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentContentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(1, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.False(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(0, lexer.CommentLevel);
        Assert.AreEqual(content.Length - 2, lexer.TokenStart);
        Assert.AreEqual(content.Length, lexer.TokenEnd);
        Assert.AreEqual(7, lexer.TokenCount);
        Assert.IsInstanceOf<BlockCommentEndToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
    }
}