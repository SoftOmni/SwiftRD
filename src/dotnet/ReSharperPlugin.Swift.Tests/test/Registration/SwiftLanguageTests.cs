using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.Psi.CSharp.Impl;
using JetBrains.ReSharper.Psi.JavaScript.LanguageImpl;
using NUnit.Framework;
using ReSharperPlugin.Swift.Language;
using ReSharperPlugin.Swift.Language.Parser.Lexer;

namespace ReSharperPlugin.Swift.Tests.test.Registration;

[TestFixture]
public class SwiftLanguageTests
{
    [Test]
    public void SwiftIsRegistered()
    {
        Assert.NotNull(SwiftLanguage.Instance);
        Assert.NotNull(Languages.Instance.GetLanguageByName(SwiftLanguage.Name));
    }

    [Test]
    public void SwiftLanguageServiceIsRegistered()
    {
        SwiftLanguageService swiftLanguageService = LanguageManager.Instance.GetService<SwiftLanguageService>(SwiftLanguage.Instance!);
        Assert.IsInstanceOf<SwiftLanguageService>(swiftLanguageService);
        
        Assert.IsInstanceOf<SwiftLexerFactory>(swiftLanguageService.GetPrimaryLexerFactory());
    }

    [Test, Explicit]
    public void DumpLanguages()
    {
        foreach (PsiLanguageType languageType in Languages.Instance.All)
        {
            Console.WriteLine(languageType.PresentableName);
        }
    }
}