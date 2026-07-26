using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Operators.Declarations;

public interface IReadOnlyInfixOperatorGroup : ISwiftInternalNode<SwiftCompositeNode>
{
    Colon InfixOperatorGroupIntroducer { get; }
    
    IReadOnlyIdentifier PrecedenceGroupName { get; }
}
