using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

public interface IReadOnlyCodeBlockGetterSetterKeywordBlock : IReadOnlyGetterSetterBlock
{
    IReadOnlyCodeBlock CodeBlock { get; }
}
