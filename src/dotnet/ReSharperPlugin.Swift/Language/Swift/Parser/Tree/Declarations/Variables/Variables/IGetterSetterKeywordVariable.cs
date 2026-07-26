using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public interface IGetterSetterKeywordVariable : IReadOnlyGetterSetterKeywordVariable, IVariable
{
    new IIdentifier Name { get; }
    
    new ITypeAnnotation TypeAnnotation { get; }
    
    new IGetterSetterKeywordBlock GetterSetterBlock { get; }

    void ChangeName(IIdentifier newName);

    void ChangeTypeAnnotation(ITypeAnnotation newTypeAnnotation);

    void ChangeGetterSetterBlock(IGetterSetterKeywordBlock newGetterSetterBlock);
}
