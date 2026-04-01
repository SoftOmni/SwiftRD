using System.Collections.Generic;
using JetBrains.ProjectModel;

namespace SoftOmni.SwiftRd.Language.ModuleMaps.File;

[ProjectFileTypeDefinition(Name)]
public class ModuleMapsFileType : KnownProjectFileType
{
    public new const string Name = "CLANG_MODULE_MAPS";
    
    public new static ModuleMapsFileType Instance { get; set; }
    
    private ModuleMapsFileType()
        : base(Name, "Clang Module Map", [ModuleMapsExtension])
    { }

    protected ModuleMapsFileType(string name)
        : base(name)
    { }

    protected ModuleMapsFileType(string name, string presentableName)
        : base(name, presentableName)
    { }

    protected ModuleMapsFileType(string name, string presentableName, IEnumerable<string> extensions)
        : base(name, presentableName, extensions)
    { }

    public const string ModuleMapsExtension = "modulemap";
}