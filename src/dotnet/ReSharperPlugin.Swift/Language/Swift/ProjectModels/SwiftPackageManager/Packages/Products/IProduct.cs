using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Modules;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Targets;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Products;

public interface IProduct
{
    string Id { get; set; }
    
    string Name { get; set; }
    
    IReadOnlySet<ITarget> Targets { get; }
    
    IReadOnlySet<ISourceModuleTarget> SourceModules { get; }
}
