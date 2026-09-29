using System.Collections.Generic;
using JetBrains.ProjectModel;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.File;

[ProjectFileTypeDefinition(Name)]
public class ObjectiveCFileType : KnownProjectFileType
{
    public new const string Name = "OBJECTIVE_C";
    
    public new static ObjectiveCFileType Instance { get; set; }
    
    private ObjectiveCFileType()
        : base(Name, "Objective-C", [ObjectiveCExtension])
    { }

    protected ObjectiveCFileType(string name)
        : base(name)
    { }

    protected ObjectiveCFileType(string name, string presentableName)
        : base(name, presentableName)
    { }

    protected ObjectiveCFileType(string name, string presentableName, IEnumerable<string> extensions)
        : base(name, presentableName, extensions)
    { }

    public const string ObjectiveCExtension = "m";
}