using System;
using JetBrains.ReSharper.Psi;
using NUnit.Framework;
using SoftOmni.SwiftRd.Language.ObjectiveC;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer;

namespace SoftOmni.SwiftRd.Tests.Tests.Registration;

[TestFixture]
public class ObjectiveCXXLanguageTests
{
    [Test]
    public void ObjectiveCXXIsRegistered()
    {
        Assert.NotNull(ObjectiveCXXLanguage.Instance);
        Assert.NotNull(Languages.Instance.GetLanguageByName(ObjectiveCXXLanguage.Name));
    }

    [Test]
    public void ObjectiveCXXLanguageServiceIsRegistered()
    {
        ObjectiveCXXLanguageService objectiveCXXLanguageService = LanguageManager.Instance.GetService<ObjectiveCXXLanguageService>(ObjectiveCXXLanguage.Instance!);
        Assert.IsInstanceOf<ObjectiveCXXLanguageService>(objectiveCXXLanguageService);
        
        Assert.IsInstanceOf<ObjectiveCXXLexerFactory>(objectiveCXXLanguageService.GetPrimaryLexerFactory());
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