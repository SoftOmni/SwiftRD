using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

public interface ICodeBlockGetterSetterKeywordBlock : 
    IReadOnlyCodeBlockGetterSetterKeywordBlock, 
    IGetterSetterBlock
{
    new ICodeBlock CodeBlock { get; }

    void ChangeCodeBlock(ICodeBlock newCodeBlock);
}
