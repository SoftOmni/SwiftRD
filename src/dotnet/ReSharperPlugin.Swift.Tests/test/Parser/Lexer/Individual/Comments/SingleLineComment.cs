using System.Text;
using JetBrains.Text;
using NUnit.Framework;
using SoftOmni.SwiftRd.Extensions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.WhitespaceAndComments;

namespace SoftOmni.SwiftRd.Tests.test.Parser.Lexer.Individual.Comments;

[TestFixture]
public class SingleLineComment
{
    [Test]
    public void Simple()
    {
        const string content = "// I use and maintain my own fork of IntelliJ btw";
        IBuffer code = new StringBuilderBuffer(new StringBuilder(content));
        SwiftLexer lexer = new(code);
        
        // Does the base case work?
        LexerBaseCase.AssessBaseCaseForLexer(lexer, content);
        
        lexer.Advance();
        
        Assert.False(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(0, lexer.CommentLevel);
        Assert.AreEqual(0, lexer.TokenStart);
        Assert.AreEqual(content.Length, lexer.TokenEnd);
        Assert.AreEqual(1, lexer.TokenCount);
        Assert.IsInstanceOf<LineCommentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
    }
    
    [Test]
    public void Several()
    {
        const string content = """
                               // I use and maintain my own fork of IntelliJ btw
                               // It's called Open IntelliJ and this Swift support will
                               // be its first major addition
                               """;

        const string firstComment = "// I use and maintain my own fork of IntelliJ btw";
        
        const string secondComment = "// It's called Open IntelliJ and this Swift support will";

        const string thirdComment = "// be its first major addition";
        
        IBuffer code = new StringBuilderBuffer(new StringBuilder(content));
        SwiftLexer lexer = new(code);
        
        // Does the base case work?
        LexerBaseCase.AssessBaseCaseForLexer(lexer, content);
        
        lexer.Advance();
        
        Assert.False(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(0, lexer.CommentLevel);
        Assert.AreEqual(0, lexer.TokenStart);
        Assert.AreEqual(firstComment.Length, lexer.TokenEnd);
        Assert.AreEqual(1, lexer.TokenCount);
        Assert.IsInstanceOf<LineCommentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.False(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(0, lexer.CommentLevel);
        Assert.AreEqual(firstComment.Length, lexer.TokenStart);
        Assert.AreEqual(2, lexer.TokenCount);
        Assert.IsInstanceOf<NewLineToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.False(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(0, lexer.CommentLevel);
        Assert.AreEqual(firstComment.Length + 1, lexer.TokenStart);
        Assert.AreEqual(firstComment.Length + 1 + secondComment.Length, lexer.TokenEnd);
        Assert.AreEqual(3, lexer.TokenCount);
        Assert.IsInstanceOf<LineCommentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.False(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(0, lexer.CommentLevel);
        Assert.AreEqual(firstComment.Length + 1 + secondComment.Length, lexer.TokenStart);
        Assert.AreEqual(4, lexer.TokenCount);
        Assert.IsInstanceOf<NewLineToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.False(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(0, lexer.CommentLevel);
        Assert.AreEqual(firstComment.Length + 1 + secondComment.Length + 1, lexer.TokenStart);
        Assert.AreEqual(firstComment.Length + 1 + secondComment.Length + 1 + thirdComment.Length, lexer.TokenEnd);
        Assert.AreEqual(5, lexer.TokenCount);
        Assert.IsInstanceOf<LineCommentToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
    }
}