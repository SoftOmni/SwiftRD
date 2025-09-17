using System;
using System.Collections.Generic;
using JetBrains.Application.Components;
using JetBrains.Application.Parts;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.CSharp.Impl;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2;
using JetBrains.ReSharper.Psi.Modules;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.ReSharper.Psi.Tree;
using ReSharperPlugin.Swift.Language.Parser;
using ReSharperPlugin.Swift.Language.Parser.FaultyParsers;
using ReSharperPlugin.Swift.Language.Parser.Lexer;
using ReSharperPlugin.Swift.Language.ProjectModel;
using ReSharperPlugin.Swift.Language.Semantics.Type;

namespace ReSharperPlugin.Swift.Language;

[Language(typeof(SwiftLanguage))]
public class SwiftLanguageService(SwiftLanguage swiftLanguage, ILazy<IConstantValueService> constantValueService)
    : LanguageService(swiftLanguage, constantValueService)
{
    public override ILexerFactory GetPrimaryLexerFactory()
    {
        Console.WriteLine("Primary lexer called!");
        return new SwiftLexerFactory();
    }

    public override ILexer CreateFilteringLexer(ILexer lexer)
    {
        Console.WriteLine("Filtering lexer called!");
        return lexer;
    }

    public override IParser CreateParser(ILexer lexer, IPsiModule? module, IPsiSourceFile? sourceFile)
    {
        Console.WriteLine("Parser called!");
        if (lexer is not SwiftFilteringLexer filteringLexer)
        {
            return new IncorrectlyStartedLexer(module, sourceFile);
        }

        SwiftPsiSourceFile? swiftPsiSourceFile;

        if (module is not SwiftPsiModule swiftPsiModule)
        {
            // ReSharper disable once MergeCastWithTypeCheck
            if (sourceFile is not SwiftPsiSourceFile)
            {
                return new SwiftParser(filteringLexer);
            }

            swiftPsiSourceFile = sourceFile as SwiftPsiSourceFile;
            return new SwiftParser(filteringLexer, sourceFile: swiftPsiSourceFile);
        }

        if (sourceFile is not SwiftPsiSourceFile)
        {
            return new SwiftParser(filteringLexer, swiftPsiModule);
        }
        
        swiftPsiSourceFile = sourceFile as SwiftPsiSourceFile;
        return new SwiftParser(filteringLexer, swiftPsiModule, swiftPsiSourceFile);
    }

    public override IEnumerable<ITypeDeclaration> FindTypeDeclarations(IFile file)
    {
        throw new NotImplementedException();
    }

    public override ILanguageCacheProvider? CacheProvider { get; } = new SwiftLanguageCacheProvider();

    public override bool IsCaseSensitive => true;

    public override bool SupportTypeMemberCache => true;

    public override ITypePresenter TypePresenter { get; } = new SwiftTypePresenter();
}