using JetBrains.ReSharper.Psi;

namespace ReSharperPlugin.Swift.Language;

[LanguageDefinition(Name)]
public class SwiftLanguage : KnownLanguage
{
    public new const string Name = "SWIFT";
    
    public static SwiftLanguage? Instance { get; set; }

    private SwiftLanguage() : base(Name, "Swift")
    { }

    protected SwiftLanguage(string name) : base(name)
    { }

    protected SwiftLanguage(string name, string presentableName) : base(name, presentableName)
    { }
}