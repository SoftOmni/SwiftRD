using JetBrains.ReSharper.Psi;

namespace SoftOmni.SwiftRd.Language.ObjectiveC;

[LanguageDefinition(Name)]
public class ObjectiveCxxLanguage : KnownLanguage
{
    public new const string Name = "OBJECTIVE-CXX";

    public static ObjectiveCLanguage? Instance { get; set; }

    private ObjectiveCxxLanguage()
        : base(Name, "Objective - C++")
    { }
    
    protected ObjectiveCxxLanguage(string name) : base(name) {}
    
    protected ObjectiveCxxLanguage(string name, string presentableName) : base(name, presentableName) {}
}
