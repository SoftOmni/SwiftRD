using System;
using JetBrains.ReSharper.Psi;
using NUnit.Framework;
using SoftOmni.SwiftRd.Language.ObjectiveC;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer;

namespace SoftOmni.SwiftRd.Tests.Tests.Registration;

[TestFixture]
public class ObjectiveCLanguageTests
{
    [Test]
    public void ObjectiveCIsRegistered()
    {
        Assert.NotNull(ObjectiveCLanguage.Instance);
        Assert.NotNull(Languages.Instance.GetLanguageByName(ObjectiveCLanguage.Name));
    }

    [Test]
    public void ObjectiveCLanguageServiceIsRegistered()
    {
        ObjectiveCLanguageService objectiveCLanguageService = LanguageManager.Instance.GetService<ObjectiveCLanguageService>(ObjectiveCLanguage.Instance!);
        Assert.IsInstanceOf<ObjectiveCLanguageService>(objectiveCLanguageService);
        
        Assert.IsInstanceOf<ObjectiveCLexerFactory>(objectiveCLanguageService.GetPrimaryLexerFactory());
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