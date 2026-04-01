using System;
using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.FileLists;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Targets;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Modules;

public interface ISourceModuleTarget : ITarget
{
    string ModuleName { get; }
    
    ModuleKind Kind { get; }
    
    IReadOnlyList<string> LinkedLibrariesRaw { get; }
    
    IReadOnlySet<ISwiftPackage> Libraries { get; }
    
    IReadOnlyList<string> LinkedFrameworksRaw { get; }
    
    IReadOnlySet<ISwiftPackage> Frameworks { get; }
    
    IReadOnlyList<string> PluginGeneratedSourcesRaw { get; }  
    
    IReadOnlySet<Uri> PluginGeneratedSources { get; }
    
    IReadOnlyList<string> PluginGeneratedResourcesRaw { get; }
    
    IReadOnlySet<Uri> PluginGeneratedResources { get; }
    
    IFileList Sources { get; }
    
    IFileList SourcesWithSuffix(string suffix);
}