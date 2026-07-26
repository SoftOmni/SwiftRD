using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Constants;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.Variables;

public interface IReadOnlyUnannotatedWillSetVariable : IReadOnlyVariable
{
    IReadOnlyIdentifier Name { get; }
    
    IReadOnlyInitializer Initializer { get; }
    
    IReadOnlyWillSetDidSetBlock WillSetDidSetBlock { get; }
}
