using System.Collections.Generic;
using JetBrains.Util;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Targets;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Modules.Swift.System;

public interface ISystemLibraryTarget : ITarget
{
    string PkgConfigRaw { get; }

    DirectoryScanner.IFileEntry PkgConfig { get; }

    IReadOnlyList<string> CompilerFlagsRaw { get; }

    IReadOnlyList<IClangSwiftCCompilerFlag> CompilerFlagsList { get; }

    IReadOnlySet<IClangSwiftCCompilerFlag> CompilerFlags { get; }

    IReadOnlyList<string> LinkerFlagsRaw { get; }

    IReadOnlyList<ILinkerFlag> LinkerFlagsList { get; }
    
    IReadOnlySet<ILinkerFlag> LinkerFlags { get; }
}