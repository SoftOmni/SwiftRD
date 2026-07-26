using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeInitializers;

public interface IReadOnlyDeInitializerDeclaration : IReadOnlyDeclaration
{
    IReadOnlyAttributeGroup? Attributes { get; }
    
    DeInit DeInitKeyword { get; }
    
    IReadOnlyCodeBlock CodeBlock { get; }
}
