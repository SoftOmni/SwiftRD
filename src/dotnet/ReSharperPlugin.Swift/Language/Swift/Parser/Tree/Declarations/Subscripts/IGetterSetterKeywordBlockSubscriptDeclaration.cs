using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

public interface IGetterSetterKeywordBlockSubscriptDeclaration :
    IReadOnlyGetterSetterKeywordBlockSubscriptDeclaration,
    ISubscriptDeclaration
{
    new IGetterSetterKeywordBlock GetterSetterKeywordBlock { get; }

    void ChangeGetterSetterKeywordBlock(IGetterSetterKeywordBlock newGetterSetterKeywordBlock);
}
