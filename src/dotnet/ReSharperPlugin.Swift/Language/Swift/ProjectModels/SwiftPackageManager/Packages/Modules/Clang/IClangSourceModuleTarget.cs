using System;
using System.Collections.Generic;
using JetBrains.Util;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Modules.Swift.Clang;

public interface IClangSourceModuleTarget : ISourceModuleTarget
{
    IReadOnlyList<string> HeaderSearchPathsRaw { get; }
    
    IReadOnlySet<DirectoryScanner.IDirectoryEntry> HeaderSearchPaths { get; }
    
    IReadOnlyList<string> PreprocessorDefinitionsRaw { get; }
    
    IReadOnlySet<string> PreprocessorDefinitions { get; }
    
    string PublicHeadersDirectoryUrlRaw { get; }
    
    Uri? PublicHeadersDirectoryUrl { get; }
}