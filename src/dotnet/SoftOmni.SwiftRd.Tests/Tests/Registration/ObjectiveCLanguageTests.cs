using System;
using JetBrains.ReSharper.Psi;
using NUnit.Framework;

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
        ObjectiveCLanguageService ObjectiveCLanguageService = LanguageManager.Instance.GetService<ObjectiveCLanguageService>(ObjectiveCLanguage.Instance!);
        Assert.IsInstanceOf<ObjectiveCLanguageService>(ObjectiveCLanguageService);
        
        Assert.IsInstanceOf<ObjectiveCLexerFactory>(ObjectiveCLanguageService.GetPrimaryLexerFactory());
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