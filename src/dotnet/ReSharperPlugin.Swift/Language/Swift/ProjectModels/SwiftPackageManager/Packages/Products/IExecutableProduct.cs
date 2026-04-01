using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Targets;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Products;

public interface IExecutableProduct : IProduct
{
    string MainTargetRaw { get; }
    
    ITarget? MainTarget { get; }
}