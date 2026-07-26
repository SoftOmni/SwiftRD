using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Attributes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.DeInitializers;

public interface IDeInitializerDeclaration : IReadOnlyDeInitializerDeclaration,
    IDeclaration
{
    new IAttributeGroup? Attributes { get; }
    
    new ICodeBlock CodeBlock { get; }

    void SetAttributesTo(IAttributeGroup? newAttributes);

    void RemoveAttributes();

    void ChangeCodeBlock(ICodeBlock newCodeBlock);
}
