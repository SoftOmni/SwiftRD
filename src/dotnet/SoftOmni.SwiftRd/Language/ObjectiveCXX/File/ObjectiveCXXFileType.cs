using System.Collections.Generic;
using JetBrains.ProjectModel;

namespace SoftOmni.SwiftRd.Language.ObjectiveCXX.File;

[ProjectFileTypeDefinition(Name)]
public class ObjectiveCXXFileType : KnownProjectFileType
{
    public new const string Name = "OBJECTIVE_CXX";
    
    public new static ObjectiveCXXFileType Instance { get; set; }
    
    private ObjectiveCXXFileType()
        : base(Name, "Objective-C++", [ObjectiveCXXExtension])
    { }

    protected ObjectiveCXXFileType(string name)
        : base(name)
    { }

    protected ObjectiveCXXFileType(string name, string presentableName)
        : base(name, presentableName)
    { }

    protected ObjectiveCXXFileType(string name, string presentableName, IEnumerable<string> extensions)
        : base(name, presentableName, extensions)
    { }

    public const string ObjectiveCXXExtension = "mm";
}