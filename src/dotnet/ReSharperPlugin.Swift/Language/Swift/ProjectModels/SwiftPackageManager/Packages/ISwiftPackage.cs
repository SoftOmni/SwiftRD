using System;
using System.Collections.Generic;

using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Origins;

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

    IReadOnlySet<ISwiftTarget> AllTargets { get; }
    
    IReadOnlyList<ISwiftTarget> TargetList { get; }

    IReadOnlySet<ISwiftTarget> Targets();

    IReadOnlyList<ISwiftTarget> Targets(IEnumerable<string> targetNames);

    IReadOnlyList<TTarget> Targets<TTarget>() where TTarget : ISwiftTarget;
    
    IReadOnlySet<ISwiftProduct> AllProducts { get; }

    IReadOnlyList<ISwiftProduct> Products();
    
    IReadOnlyList<ISwiftProduct> Products(IEnumerable<string> productNames);

    IReadOnlyList<TProduct> Products<TProduct>()
        where TProduct : ISwiftProduct;
}