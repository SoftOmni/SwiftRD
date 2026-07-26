using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.TypeAnnotations;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public interface IAnnotatedWillSetDidSetVariable : IReadOnlyAnnotatedWillSetVariable, IVariable
{
    new IIdentifier Name { get; }
    
    new ITypeAnnotation TypeAnnotation { get; }
    
    new IInitializer? Initializer { get; }
    
    new IWillSetDidSetBlock WillSetDidSetBlock { get; }

    void ChangeName(IIdentifier newName);

    void SetInitializerTo(IInitializer newInitializer);

    void ChangeTypeAnnotation(ITypeAnnotation newTypeAnnotation);

    void RemoveInitializer();

    void ChangeWillSetDidSetBlock(IWillSetDidSetBlock newWillSetDidSetBlock);
}
