using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Subscripts;

public interface IReadOnlyGetterSetterBlockSubscriptDeclaration : IReadOnlySubscriptDeclaration
{
    IReadOnlyGetterSetterBlock GetterSetterBlock { get; }
}
