using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Associativity;

public interface IReadOnlyPrecedenceGroupAssociativity : ISwiftInternalNode<SwiftCompositeNode>,
    IReadOnlyPrecedenceGroupAttribute
{
    Associativity AssociativityKeyword { get; }
    
    Colon AssociativityIntroducer { get; }
}
