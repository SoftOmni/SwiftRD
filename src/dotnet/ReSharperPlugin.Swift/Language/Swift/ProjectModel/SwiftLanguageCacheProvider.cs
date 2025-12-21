using JetBrains.ReSharper.Psi;
using JetBrains.ReSharper.Psi.ExtensionsAPI.Caches2;
using JetBrains.ReSharper.Psi.Modules;
using JetBrains.ReSharper.Psi.Tree;

namespace ReSharperPlugin.Swift.Language.ProjectModel;

public class SwiftLanguageCacheProvider : ILanguageCacheProvider
{
    public Part ReadPart(byte tag, IReader reader)
    {
        throw new System.NotImplementedException();
    }

    public ProjectFilePart LoadProjectFilePart(IPsiSourceFile? sourceFile, ProjectFilePartsTree tree, IReader reader)
    {
        throw new System.NotImplementedException();
    }

    public bool IsCaseSensitive(IPsiModule module)
    {
        throw new System.NotImplementedException();
    }

    public void BuildCache(IFile file, ICacheBuilder builder)
    {
        throw new System.NotImplementedException();
    }

    public void BuildCache(ISandBox sandBox, ICacheBuilder builder)
    {
        throw new System.NotImplementedException();
    }
}