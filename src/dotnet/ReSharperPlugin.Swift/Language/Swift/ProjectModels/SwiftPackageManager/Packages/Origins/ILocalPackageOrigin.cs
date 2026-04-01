using System;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Origins;

public interface ILocalPackageOrigin : IPackageOrigin
{
    string PathRaw { get; }
    
    Uri? Path { get; }

    bool IsLocalPackage();

    bool IsValid();
    
    bool Exists();

    bool ExistsAndIsValid();
}