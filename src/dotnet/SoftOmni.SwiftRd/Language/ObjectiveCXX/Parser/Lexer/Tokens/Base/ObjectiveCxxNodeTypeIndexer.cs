using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;

public class ObjectiveCxxNodeTypeIndexer : NodeTypesRegistry
{
    public static readonly ObjectiveCxxNodeTypeIndexer Instance = new();
    
    private ObjectiveCxxNodeTypeIndexer()
    { }
}
