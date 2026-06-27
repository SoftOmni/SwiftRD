using JetBrains.ReSharper.Psi;

namespace SoftOmni.SwiftRd.Language.RegularExpressionHarness;

[LanguageDefinition(Name)]
public class SwiftRegularExpressionLanguage : KnownLanguage
{
    public new const string Name = "Swift regular expressions";

    public static SwiftRegularExpressionLanguage? Instance { get; set; }

    private SwiftRegularExpressionLanguage()
        : base(Name, "Swift Regex")
    { }

    protected SwiftRegularExpressionLanguage(string name)
        : base(name)
    { }

    protected SwiftRegularExpressionLanguage(string name, string presentableName)
        : base(name, presentableName)
    { }
}
