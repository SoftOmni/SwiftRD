using System;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp;
using JetBrains.ReSharper.Psi.CSharp.Impl;
using JetBrains.ReSharper.Psi.JavaScript.LanguageImpl;
using NUnit.Framework;
using SoftOmni.SwiftRd.Language;
using SoftOmni.SwiftRd.Language.Swift.Parser.Lexer;

namespace SoftOmni.SwiftRd.Tests.test.Registration;

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