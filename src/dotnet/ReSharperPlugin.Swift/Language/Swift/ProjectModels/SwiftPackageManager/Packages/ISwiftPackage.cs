using System;
using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Modules.Swift.Swift;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Origins;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Products;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Targets;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages;

public interface ISwiftPackage
{
    string Id { get; }

    string DisplayName { get; }

    Version ToolsVersion { get; }

    Uri? DirectoryUri { get; }

    bool IsAppleStandardLibrary { get; }

    IPackageOrigin PackageOrigin { get; }

    IReadOnlySet<ISwiftPackage> Dependencies { get; }

    IReadOnlySet<ISwiftSourceModuleTarget> SourceModuleTargets { get; }

    IReadOnlySet<ITarget> AllTargets { get; }
    
    IReadOnlyList<ITarget> TargetList { get; }

    IReadOnlySet<ITarget> Targets();

    IReadOnlyList<ITarget> Targets(IEnumerable<string> targetNames);

    IReadOnlyList<TTarget> Targets<TTarget>() where TTarget : ITarget;
    
    IReadOnlySet<IProduct> AllProducts { get; }

    IReadOnlyList<IProduct> Products();
    
    IReadOnlyList<IProduct> Products(IEnumerable<string> productNames);

    IReadOnlyList<TProduct> Products<TProduct>()
        where TProduct : IProduct;
}