using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks.Clauses;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;

public interface IWillSetDidSetBlock : IReadOnlyWillSetDidSetBlock
{
    new IWillSetClause? WillSetClause { get; }
    
    new IDidSetClause? DidSetClause { get; }

    void MakeWillSetFirst();

    void MakeDidSetFirst();
    
    void Invert();
}
