using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Initializers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Patterns;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LoopStatements.Conditions.Conditions.CaseConditions;

public interface IReadOnlyCaseCondition : IReadOnlyCondition, ISwiftInternalNode<SwiftCompositeNode>
{
    Case Case { get; }
    
    IReadOnlyPattern Pattern { get; }
    
    IReadOnlyInitializerDeclaration Initializer { get; }
}
