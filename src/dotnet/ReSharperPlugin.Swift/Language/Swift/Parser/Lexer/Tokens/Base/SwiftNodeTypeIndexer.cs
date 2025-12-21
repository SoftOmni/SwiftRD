using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace ReSharperPlugin.Swift.Language.Parser.Lexer.Tokens.Base;

public class SwiftNodeTypeIndexer : AbstractNodeTypeIndexer
{
    public static readonly SwiftNodeTypeIndexer Instance = new();
    
    private SwiftNodeTypeIndexer()
    { }
}