using System;
using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using JetBrains.UI.Icons;
using JetBrains.Util.Dotnet.TargetFrameworkIds;
using SoftOmni.SwiftRd.Language.File;
using SoftOmni.SwiftRd.Language.Swift;
using SoftOmni.SwiftRd.Language.Ui.Icons;

namespace SoftOmni.SwiftRd;

public class SwiftFileLanguageService : IProjectFileLanguageService
{
    public PsiLanguageType GetPsiLanguageType(IProjectFile projectFile)
    {
        return SwiftLanguage.Instance!;
    }

    public PsiLanguageType GetPsiLanguageType(IPsiSourceFile sourceFile)
    {
        return SwiftLanguage.Instance!;
    }

    public IPsiSourceFileProperties? GetPsiProperties(IProjectFile projectFile, IPsiSourceFile sourceFile,
        IsCompileService isCompileService)
    {
        throw new NotImplementedException();
    }

    public PsiLanguageType GetPsiLanguageType(ProjectFileType languageType)
    {
        throw new NotImplementedException();
    }

    public ILexerFactory? GetMixedLexerFactory(ISolution solution, IBuffer buffer, IPsiSourceFile sourceFile = null)
    {
        throw new NotImplementedException();
    }

    public PreProcessingDirective[] GetPreprocessorDefines(IProject project, TargetFrameworkId targetFrameworkId)
    {
        throw new NotImplementedException();
    }

    public ProjectFileType LanguageType => SwiftProjectFileType.Instance;

    public IconId Icon => SwiftIconManager.LanguageIcon;
}