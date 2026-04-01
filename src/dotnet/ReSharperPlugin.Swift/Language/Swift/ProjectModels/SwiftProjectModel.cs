using System.Collections.Generic;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.Modules;
using SoftOmni.SwiftRd.Language.Swift.ProjectModels.SwiftPackageManager.Packages.Modules;
using SoftOmni.SwiftRd.Technology.Graphs;

namespace SoftOmni.SwiftRd.Language.Swift.ProjectModels;

public interface ISwiftProjectModel
{
    IReadOnlyGraph<(ISwiftModule module, ModuleKind swiftModuleType)> Dependencies { get; }

    IReadOnlySet<ISwiftModule> UserModules { get; }
    
    IReadOnlySet<ISwiftModule> AllModules { get; }
    
    IReadOnlySet<ISwiftModule> NonStandardLibraryLibraries { get; }

    IStandardLibrarySwiftModule? StandardLibrary { get; }
    
    bool IsAppleStandardLibrary { get; }
    
    bool SupportsObjectiveCInteroperability { get; }
    
    bool SupportsObjectiveCxxInteroperability { get; }
    
    bool SupportsCxxInteroperability { get; }

    bool SupportsJavaInteroperability { get; }
    
    bool SupportsKotlinInteroperability { get; }

    bool ReliesOnObjectiveCInteroperability();
    
    bool ReliesOnObjectiveCxxInteroperability();

    bool ReliesOnCxxInteroperability();
    
    bool ReliesOnJavaInteroperability();
    
    bool ReliesOnKotlinInteroperability();

    bool IsStandaloneSwiftCode();
}