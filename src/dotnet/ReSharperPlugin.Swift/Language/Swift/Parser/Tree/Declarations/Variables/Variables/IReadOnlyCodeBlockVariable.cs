using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public interface IReadOnlyCodeBlockVariable : IReadOnlyVariable
{
    IReadOnlyIdentifier Name { get; }
    
    IReadOnlyTypeAnnotation TypeAnnotation { get; }
    
    IReadOnlyCodeBlock CodeBlock { get; }
}
