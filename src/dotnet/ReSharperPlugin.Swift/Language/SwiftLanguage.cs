using JetBrains.Annotations;
using JetBrains.ReSharper.Psi;

namespace ReSharperPlugin.Swift.Language;

[LanguageDefinition(Name)]
public class SwiftLanguage : KnownLanguage
{
    public new const string Name = "SWIFT";

    [CanBeNull] public static readonly SwiftLanguage Instance;
    
    private SwiftLanguage() : base(Name, "Swift")
    { }
    
    protected SwiftLanguage([NotNull] string name) : base(name)
    { }
    
    protected SwiftLanguage([NotNull] string name, [NotNull] string presentableName) : base(name, presentableName)
    { }
}