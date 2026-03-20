using System.Collections.Generic;
using JetBrains.ProjectModel;

namespace ReSharperPlugin.Swift.Language.ObjectiveCXX.File;

[ProjectFileTypeDefinition(Name)]
public class ObjectiveCxxFileType : KnownProjectFileType
{
    public new const string Name = "OBJECTIVE_CXX";
    
    public new static ObjectiveCxxFileType Instance { get; set; }
    
    private ObjectiveCxxFileType()
        : base(Name, "Objective-C++", [ObjectiveCxxExtension])
    { }

    protected ObjectiveCxxFileType(string name)
        : base(name)
    { }

    protected ObjectiveCxxFileType(string name, string presentableName)
        : base(name, presentableName)
    { }

    protected ObjectiveCxxFileType(string name, string presentableName, IEnumerable<string> extensions)
        : base(name, presentableName, extensions)
    { }

    public const string ObjectiveCxxExtension = "mm";
}