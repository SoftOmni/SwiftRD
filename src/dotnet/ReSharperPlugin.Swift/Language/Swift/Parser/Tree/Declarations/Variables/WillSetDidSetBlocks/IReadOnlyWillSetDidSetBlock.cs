using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks.Clauses;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Variables.WillSetDidSetBlocks;

public interface IReadOnlyWillSetDidSetBlock : ISwiftInternalNode<SwiftCompositeNode>
{
    LeftCurlyBrace WillSetDidSetBlockStart { get; }
    
    IReadOnlyWillSetClause? WillSetClause { get; }
    
    IReadOnlyDidSetClause? DidSetClause { get; }
    
    RightCurlyBrace WillSetDidSetBlockEnd { get; }

    bool WillSetIsFirst();

    bool DidSetIsFirst();
    
    bool CanInvert();
}
