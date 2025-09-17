using JetBrains.ProjectModel;
using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.Parsing;
using JetBrains.Text;
using JetBrains.UI.Icons;
using JetBrains.Util.Dotnet.TargetFrameworkIds;
using ReSharperPlugin.Swift.Language;
using ReSharperPlugin.Swift.Language.File;
using ReSharperPlugin.Swift.Language.Ui.Icons;

namespace ReSharperPlugin.Swift;

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
        throw new System.NotImplementedException();
    }

    public PsiLanguageType GetPsiLanguageType(ProjectFileType languageType)
    {
        throw new System.NotImplementedException();
    }

    public ILexerFactory? GetMixedLexerFactory(ISolution solution, IBuffer buffer, IPsiSourceFile sourceFile = null)
    {
        throw new System.NotImplementedException();
    }

    public PreProcessingDirective[] GetPreprocessorDefines(IProject project, TargetFrameworkId targetFrameworkId)
    {
        throw new System.NotImplementedException();
    }

    public ProjectFileType LanguageType => SwiftProjectFileType.Instance;

    public IconId Icon => SwiftIconManager.LanguageIcon;
}