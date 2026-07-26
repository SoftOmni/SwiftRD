using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.InternalNode;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.RawValue;

public interface IReadOnlyRawValueStyleEnumCase : ISwiftInternalNode<SwiftCompositeNode>
{
    IReadOnlyIdentifier Name { get; }
    
    Equal? AssignmentOperator { get; }
    
    IReadOnlyLiteral? Literal { get; }
}
