using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

public class SwiftNodeTypeIndexer : NodeTypesRegistry
{
    public static readonly SwiftNodeTypeIndexer Instance = new();
    
    private SwiftNodeTypeIndexer()
    { }
}