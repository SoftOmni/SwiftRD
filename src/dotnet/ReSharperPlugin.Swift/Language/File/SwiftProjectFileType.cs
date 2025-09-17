using System.Collections.Generic;
using JetBrains.ProjectModel;

namespace ReSharperPlugin.Swift.Language.File;

[ProjectFileTypeDefinition(Name)]
public class SwiftProjectFileType : KnownProjectFileType
{
    public new const string Name = "SWIFT";
    
    public new static SwiftProjectFileType Instance { get; set; }

    private SwiftProjectFileType()
        : base(Name, "Swift", [SwiftExtension])
    { }

    protected SwiftProjectFileType(string name)
        : base(name)
    { }

    protected SwiftProjectFileType(string name, string presentableName)
        : base(name, presentableName)
    { }

    protected SwiftProjectFileType(string name, string presentableName, IEnumerable<string> extensions)
        : base(name, presentableName, extensions)
    { }

    public const string SwiftExtension = "swift";
}