using System;
using JetBrains.Annotations;
using JetBrains.Text;
using NUnit.Framework;
using ReSharperPlugin.Swift.Extensions;
using ReSharperPlugin.Swift.Language.Parser.Lexer;

namespace ReSharperPlugin.Swift.Tests.test.Parser.Lexer;

public class LexerBaseCase
{
    public static void AssessBaseCaseForLexer(SwiftLexer lexer, string bufferValue)
    {
        Assert.False(lexer.IsInBlockComment);
        Assert.True(lexer.IsInInterpolation.IsEmpty());
        Assert.True(lexer.IsInMultilinePairSearch.IsEmpty());
        Assert.True(lexer.IsInSimplePairSearch.IsEmpty());
        Assert.True(lexer.MultilineStringLiteralTypesStacks.IsEmpty());
        Assert.AreEqual(0, lexer.CommentLevel);
        Assert.AreEqual(0, lexer.TokenStart);
        Assert.AreEqual(0, lexer.TokenEnd);
        Assert.AreEqual(0, lexer.TokenCount);
        
        AssertExtensions.AreEqual(bufferValue, lexer.Buffer);
        
        Assert.IsNull(lexer.TokenType);
        Assert.IsNull(lexer.ThreeQuotesSettingInEffect);
        Assert.IsNull(lexer.FourQuotesSettingInEffect);
        Assert.IsNull(lexer.FiveQuotesSettingInEffect);
        Assert.AreEqual(0, lexer.LexerStateEx);
    }
}

public static class AssertExtensions
{
    [ContractAnnotation("expected:null,actual:notnull => halt;expected:notnull,actual:null => halt")]
    public static void AreEqual(string expected, IBuffer actual)
    {
        Assert.AreEqual(expected.Length, actual.Length);

        for (int i = 0; i < actual.Length; i++)
        {
            Assert.AreEqual(expected[i], actual[i]);
        }
    }

    [ContractAnnotation("expected:null => halt;expected:notnull,actual:null => halt")]
    public static void AreEqual(string expected, ReadOnlySpan<char> actual)
    {
        Assert.AreEqual(expected.Length, actual.Length);
        
        for (int i = 0; i < actual.Length; i++)
        {
            Assert.AreEqual(expected[i], actual[i]);
        }
    }
}