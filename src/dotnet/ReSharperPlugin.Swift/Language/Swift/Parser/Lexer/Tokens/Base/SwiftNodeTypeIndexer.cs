using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Lexer.Tokens.Base;

public class SwiftNodeTypeIndexer : AbstractNodeTypeIndexer
{
    public static readonly SwiftNodeTypeIndexer Instance = new();
    
    private SwiftNodeTypeIndexer()
    { }
}