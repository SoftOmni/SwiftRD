using JetBrains.ReSharper.Psi.ExtensionsAPI.Tree;

namespace SoftOmni.SwiftRd.Language.ObjectiveC.Parser.Lexer.Tokens.Base;

public class ObjectiveCNodeTypeIndexer : NodeTypesRegistry
{
    public static readonly ObjectiveCNodeTypeIndexer Instance = new();
    
    private ObjectiveCNodeTypeIndexer()
    { }
}
