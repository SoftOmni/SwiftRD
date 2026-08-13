using System.Text;
using JetBrains.Text;
using NUnit.Framework;
using SoftOmni.SwiftRd.Extensions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Markers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.WhitespaceAndComments;

namespace SoftOmni.SwiftRd.Tests.Tests.Parser.Lexer.Individual.NewLine;

[TestFixture]
public class NewLine
{
    [Test]
    public void LineFeeds()
    {
        const string content = "\n\n\n";
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
        Assert.AreEqual(1, lexer.TokenEnd);
        Assert.AreEqual(1, lexer.TokenCount);
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
        Assert.AreEqual(1, lexer.TokenStart);
        Assert.AreEqual(2, lexer.TokenEnd);
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
        Assert.AreEqual(2, lexer.TokenStart);
        Assert.AreEqual(content.Length, lexer.TokenEnd);
        Assert.AreEqual(3, lexer.TokenCount);
        Assert.IsInstanceOf<NewLineToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
    }
    
    [Test]
    public void CarriageReturns()
    {
        const string content = "\r\r\r";
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
        Assert.AreEqual(1, lexer.TokenEnd);
        Assert.AreEqual(1, lexer.TokenCount);
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
        Assert.AreEqual(1, lexer.TokenStart);
        Assert.AreEqual(2, lexer.TokenEnd);
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
        Assert.AreEqual(2, lexer.TokenStart);
        Assert.AreEqual(content.Length, lexer.TokenEnd);
        Assert.AreEqual(3, lexer.TokenCount);
        Assert.IsInstanceOf<NewLineToken>(lexer.TokenType);
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
        const string content = "\r\n\r\n\n\n\r";
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
        Assert.AreEqual(2, lexer.TokenEnd);
        Assert.AreEqual(1, lexer.TokenCount);
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
        Assert.AreEqual(2, lexer.TokenStart);
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
        Assert.AreEqual(5, lexer.TokenEnd);
        Assert.AreEqual(3, lexer.TokenCount);
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
        Assert.AreEqual(5, lexer.TokenStart);
        Assert.AreEqual(6, lexer.TokenEnd);
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
        Assert.AreEqual(6, lexer.TokenStart);
        Assert.AreEqual(7, lexer.TokenEnd);
        Assert.AreEqual(5, lexer.TokenCount);
        Assert.IsInstanceOf<NewLineToken>(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
        
        lexer.Advance();
        
        Assert.IsInstanceOf<EndOfFileToken>(lexer.TokenType);
    }
}