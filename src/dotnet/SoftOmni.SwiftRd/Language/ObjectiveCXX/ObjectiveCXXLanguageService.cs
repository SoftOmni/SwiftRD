using System.Collections.Generic;
using JetBrains.Application.Components;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2;
using JetBrains.ReSharper.Psi.Modules;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;

namespace SoftOmni.SwiftRd.Language.ObjectiveC;

[Language(typeof(ObjectiveCXXLanguage))]
public class ObjectiveCXXLanguageService(ObjectiveCXXLanguage objectiveCXXLanguage, ILazy<IConstantValueService> constantValueService)
    : LanguageService(objectiveCXXLanguage, constantValueService)
{
    public override ILexerFactory GetPrimaryLexerFactory()
    {
        throw new System.NotImplementedException();
    }

    public override ILexer CreateFilteringLexer(ILexer lexer)
    {
        throw new System.NotImplementedException();
    }

    public override IParser CreateParser(ILexer lexer, IPsiModule? module, IPsiSourceFile? sourceFile)
    {
        throw new System.NotImplementedException();
    }

    public override IEnumerable<ITypeDeclaration> FindTypeDeclarations(IFile file)
    {
        throw new System.NotImplementedException();
    }

    public override ILanguageCacheProvider? CacheProvider { get; }

    public override bool IsCaseSensitive => true;

    public override bool SupportTypeMemberCache => true;

    public override bool ParticipatesInClrCaches => true;

    public override ITypePresenter TypePresenter { get; }
}

