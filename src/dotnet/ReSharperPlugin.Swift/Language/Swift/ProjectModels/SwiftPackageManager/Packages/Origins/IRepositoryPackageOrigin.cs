using System;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Origins;

public interface IRepositoryPackageOrigin : IPackageOrigin
{
    string UrlRaw { get; }
    
    Uri? Url { get; }
    
    string DisplayVersion { get; }
    
    bool IsDisplayNameValid();
    
    string ScmRevision { get; }
    
    bool IsScmRevisionValid();

    bool IsReachable();
    
    bool IsDownloadable();

    bool IsCached();
    
    void Redownload();
    
    void Cache();
    
    bool IsOutOfDate();
}