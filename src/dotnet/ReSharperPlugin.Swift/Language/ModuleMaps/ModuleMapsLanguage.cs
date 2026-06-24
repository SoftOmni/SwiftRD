using JetBrains.ReSharper.Psi;

namespace SoftOmni.SwiftRd.Language.ModuleMaps;

[LanguageDefinition(Name)]
public class ModuleMapsLanguage : KnownLanguage
{
    public new const string Name = "CLANG-MODULE-MAPS";
    
    public static ModuleMapsLanguage? Instance { get; set; }
    
    private ModuleMapsLanguage() : base(Name, "Clang ModuleMaps")
    { }
    
    protected ModuleMapsLanguage(string name): base(name)
    { }

    protected ModuleMapsLanguage(string name, string presentableName)
        : base(name, presentableName)
    { }
}
