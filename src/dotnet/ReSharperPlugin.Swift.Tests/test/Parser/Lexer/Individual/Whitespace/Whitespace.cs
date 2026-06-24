using System.Text;
using JetBrains.Text;
using SoftOmni.SwiftRd.Extensions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.WhitespaceAndComments;

namespace SoftOmni.SwiftRd.Tests.test.Parser.Lexer.Individual.Whitespace;

[TestFixture]
public class Whitespace
{
    [Test]
    public void Spaces()
    {
        const string content = "\x20\x20\x20\x20";
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
        Assert.IsInstanceOf<WhitespaceToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);

        lexer.Advance();

        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
    }

    [Test]
    public void Tabs()
    {
        const string content = "\x09\x09\x09\x09";
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
        Assert.IsInstanceOf<WhitespaceToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);

        lexer.Advance();

        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
    }

    [Test]
    public void Mixed()
    {
        const string content = "\x20\x09\x09\x20";
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
        Assert.IsInstanceOf<WhitespaceToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);

        lexer.Advance();

        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
    }

    [Test]
    public void MixedMultipleLines()
    {
        const string content = "\x20\x20\x09\x0A\x09\x20\x0A";
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
        Assert.AreEqual(3, lexer.TokenEnd);
        Assert.AreEqual(1, lexer.TokenCount);
        Assert.IsInstanceOf<WhitespaceToken>(lexer.TokenType);
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
        Assert.AreEqual(3, lexer.TokenStart);
        Assert.AreEqual(4, lexer.TokenEnd);
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
        Assert.AreEqual(4, lexer.TokenStart);
        Assert.AreEqual(6, lexer.TokenEnd);
        Assert.AreEqual(3, lexer.TokenCount);
        Assert.IsInstanceOf<WhitespaceToken>(lexer.TokenType);
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
        Assert.AreEqual(6, lexer.TokenStart);
        Assert.AreEqual(7, lexer.TokenEnd);
        Assert.AreEqual(4, lexer.TokenCount);
        Assert.IsInstanceOf<NewLineToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);

        lexer.Advance();

        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
    }
}