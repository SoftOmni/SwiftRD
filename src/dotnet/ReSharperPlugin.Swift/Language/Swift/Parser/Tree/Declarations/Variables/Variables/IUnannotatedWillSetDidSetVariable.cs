using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public interface IUnannotedWillSetDidSetVariable : IReadOnlyUnannotatedWillSetVariable, IVariable
{
    new IIdentifier Name { get; }
    
    new IInitializer Initializer { get; }
    
    new IWillSetDidSetBlock WillSetDidSetBlock { get; }

    void ChangeName(IIdentifier newName);

    void ChangeInitializer(IInitializer newInitializer);

    void ChangeWillSetDidSetBlock(IWillSetDidSetBlock newWillSetDidSetBlock);
}
