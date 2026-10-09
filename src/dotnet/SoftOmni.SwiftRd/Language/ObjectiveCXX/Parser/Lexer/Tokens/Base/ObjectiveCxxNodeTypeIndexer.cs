using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;

public class ObjectiveCXXNodeTypeIndexer : NodeTypesRegistry
{
    public static readonly ObjectiveCXXNodeTypeIndexer Instance = new();
    
    private ObjectiveCXXNodeTypeIndexer()
    { }
}
