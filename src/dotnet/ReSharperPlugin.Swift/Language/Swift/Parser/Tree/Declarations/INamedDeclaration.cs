using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations;

public interface INamedDeclaration<TDeclaration, TUsage>
    where TDeclaration : IDeclaration<TUsage> where TUsage : IRenamableUsage
{
    Identifier? Name { get; }

    void Rename(TUsage usage, string newName);
    
    void RenameAllUsages(string newName);
}