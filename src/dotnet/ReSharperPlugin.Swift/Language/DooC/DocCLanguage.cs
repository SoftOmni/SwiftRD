using JetBrains.ReSharper.Psi;

namespace SoftOmni.SwiftRd.Language.DocC;

[LanguageDefinition(Name)]
public class DocCLanguage : KnownLanguage
{
    public new const string Name = "DocC";
    
    public static DocCLanguage? Instance { get; set; }
    
    private DocCLanguage() : base(Name, "DocC")
    { }
    
    protected DocCLanguage(string name): base(name)
    { }

    protected DocCLanguage(string name, string presentableName)
        : base(name, presentableName)
    { }
}
