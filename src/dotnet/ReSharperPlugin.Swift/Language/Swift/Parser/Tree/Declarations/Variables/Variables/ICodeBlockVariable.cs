using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.CodeBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public interface ICodeBlockVariable : IReadOnlyCodeBlockVariable, IVariable
{
    new IIdentifier Name { get; }

    void ChangeNam(IIdentifier newName);
    
    new ITypeAnnotation TypeAnnotation { get; }

    void ChangeTypeAnnotation(ITypeAnnotation newTypeAnnotation);
    
    new ICodeBlock CodeBlock { get; }

    void ChangeCodeBlock(ICodeBlock newCodeBlock);
}
