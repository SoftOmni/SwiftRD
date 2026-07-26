using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Assignment;

public interface IPrecedenceAssignmentGroup : IReadOnlyPrecedenceAssignmentGroup,
    IPrecedenceGroupAttribute
{
    new ILiteral AssignmentValue { get; }

    void ChangeAssignmentValue(ILiteral newAssignmentValue);

    void MakeTrue();

    void MakeFalse();

    void Invert();
}
