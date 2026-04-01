using System;
using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Modules;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Targets;

public interface ITarget
{
    string Id { get; }

    string Name { get; }
    
    string UrlRaw { get; }
    
    Uri? Url { get; }
    
    ISourceModuleTarget? SourceModule { get; }
    
    IReadOnlySet<TargetDependency> Dependencies { get; }
    
    IReadOnlyList<TargetDependency> DependenciesList { get; }
    
    IReadOnlyList<string> DependenciesRaw { get; }

    IReadOnlySet<ITarget> TargetDependencies();
}