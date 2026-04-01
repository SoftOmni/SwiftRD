using System.Collections.Generic;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Modules.Swift.Swift;

public interface ISwiftSourceModuleTarget : ISourceModuleTarget
{
    IReadOnlyList<string> CompilationConditionsRaw { get; }
    
    IReadOnlySet<ISwiftCompilationConditions> CompilationConditions { get; }
}