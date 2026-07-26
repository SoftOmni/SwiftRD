using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions.Conditions.OptionalBindingConditions;

public interface IReadOnlyOptionalBindingCondition :
    ISwiftInternalNode<SwiftCompositeNode>, IReadOnlyCondition
{
    IReadOnlyPattern Pattern { get; }
    
    IReadOnlyInitializerDeclaration? Initializer { get; }
}
