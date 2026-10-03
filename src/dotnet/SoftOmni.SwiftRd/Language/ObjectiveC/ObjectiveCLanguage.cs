using JetBrains.ReSharper.Psi;

namespace SoftOmni.SwiftRd.Language.ObjectiveC;

[LanguageDefinition(Name)]
public class ObjectiveCLanguage : KnownLanguage
{
    public new const string Name = "OBJECTIVE-C";

    public static ObjectiveCLanguage? Instance { get; set; }

    private ObjectiveCLanguage()
        : base(Name, "Objective - C")
    { }
    
    protected ObjectiveCLanguage(string name) : base(name) {}
    
    protected ObjectiveCLanguage(string name, string presentableName) : base(name, presentableName) {}
}
