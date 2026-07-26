using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public interface IReadOnlyAnnotatedWillSetVariable : IReadOnlyVariable
{
    IReadOnlyIdentifier Name { get; }
    
    IReadOnlyTypeAnnotation TypeAnnotation { get; }
    
    IReadOnlyInitializer? Initializer { get; }
    
    IReadOnlyWillSetDidSetBlock WillSetDidSetBlock { get; }
}
