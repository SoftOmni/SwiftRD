using System;
using JetBrains.ReSharper.Psi;
using NUnit.Framework;
using SoftOmni.SwiftRd.Language.ObjectiveC;
using SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer;

namespace SoftOmni.SwiftRd.Tests.Tests.Registration;

[TestFixture]
public class ObjectiveCxxLanguageTests
{
    [Test]
    public void ObjectiveCxxIsRegistered()
    {
        Assert.NotNull(ObjectiveCxxLanguage.Instance);
        Assert.NotNull(Languages.Instance.GetLanguageByName(ObjectiveCxxLanguage.Name));
    }

    [Test]
    public void ObjectiveCxxLanguageServiceIsRegistered()
    {
        ObjectiveCxxLanguageService objectiveCxxLanguageService = LanguageManager.Instance.GetService<ObjectiveCxxLanguageService>(ObjectiveCxxLanguage.Instance!);
        Assert.IsInstanceOf<ObjectiveCxxLanguageService>(objectiveCxxLanguageService);
        
        Assert.IsInstanceOf<ObjectiveCxxLexerFactory>(objectiveCxxLanguageService.GetPrimaryLexerFactory());
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