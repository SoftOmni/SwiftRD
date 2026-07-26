using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

public interface IGetterSetterBlockSubscriptDeclaration : IReadOnlyGetterSetterBlockSubscriptDeclaration,
    ISubscriptDeclaration
{
    new IGetterSetterBlock GetterSetterBlock { get; }

    void ChangeGetterSetterBlock(IGetterSetterBlock newGetterSetterBlock);
}
