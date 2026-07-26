using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Assignment;

public interface IReadOnlyPrecedenceAssignmentGroup : IReadOnlyPrecedenceGroupAttribute
{
    Assignment AssignmentKeyword { get; }
    
    Colon AssignmentValueIntroducer { get; }
    
    IReadOnlyLiteral AssignmentValue { get; }
}
