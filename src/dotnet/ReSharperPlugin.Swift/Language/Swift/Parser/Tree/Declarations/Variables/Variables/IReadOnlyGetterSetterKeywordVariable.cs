using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.GetterSetterBlocks.RegularBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public interface IReadOnlyGetterSetterVariable : IReadOnlyVariable
{
    IReadOnlyIdentifier Name { get; }
    
    IReadOnlyTypeAnnotation TypeAnnotation { get; }
    
    IReadOnlyGetterSetterBlock GetterSetterBlock { get; }
}
