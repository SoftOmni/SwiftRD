using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

public interface ICodeBlockGetterSetterBlock : IReadOnlyCodeBlockGetterSetterBlock, IGetterSetterBlock
{
    new ICodeBlock CodeBlock { get; }

    void ChangeCodeBlock(ICodeBlock newCodeBlock);
}
