using System;
using JetBrains.Util;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.FileLists;

public interface IFile
{
    FileType Type { get; }
    
    Uri Uri { get; }
    
    DirectoryScanner.IFileEntry EquivalentReSharperEntry { get; }
}