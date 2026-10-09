using JetBrains.ReSharper.Psi;

namespace SoftOmni.SwiftRd.Language.ObjectiveC;

[LanguageDefinition(Name)]
public class ObjectiveCXXLanguage : KnownLanguage
{
    public new const string Name = "OBJECTIVE-CXX";

    public static ObjectiveCLanguage? Instance { get; set; }

    private ObjectiveCXXLanguage()
        : base(Name, "Objective - C++")
    { }
    
    protected ObjectiveCXXLanguage(string name) : base(name) {}
    
    protected ObjectiveCXXLanguage(string name, string presentableName) : base(name, presentableName) {}
}
