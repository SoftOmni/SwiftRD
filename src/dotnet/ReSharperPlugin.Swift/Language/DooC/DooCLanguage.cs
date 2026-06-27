using JetBrains.ReSharper.Psi;

namespace SoftOmni.SwiftRd.Language.DooC;

[LanguageDefinition(Name)]
public class DooCLanguage : KnownLanguage
{
    public new const string Name = "DooC";
    
    public static DooCLanguage? Instance { get; set; }
    
    private DooCLanguage() : base(Name, "DooC")
    { }
    
    protected DooCLanguage(string name): base(name)
    { }

    protected DooCLanguage(string name, string presentableName)
        : base(name, presentableName)
    { }
}
