using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

public interface IReadOnlyGetterSetterKeywordSubscriptDeclaration : IReadOnlySubscriptDeclaration
{
    IReadOnlyGetterSetterKeywordBlock GetterSetterBlock { get; }
}
