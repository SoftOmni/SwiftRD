using System;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.Modules;

public interface IStandardLibrarySwiftModule : ISwiftModule
{
    public Version Version { get; }
    
    public bool IsAppleStandardLibrary { get; }
}