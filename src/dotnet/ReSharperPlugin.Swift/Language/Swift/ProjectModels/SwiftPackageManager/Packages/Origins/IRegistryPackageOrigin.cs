using System;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Origins;

public interface IRegistryPackageOrigin : IPackageOrigin
{
    string Identity { get; }
    
    string DisplayVersionRaw { get; }
    
    Version? DisplayVersion { get; }
}