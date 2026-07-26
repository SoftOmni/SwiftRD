using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Assignment;

public interface IAssignmentPrecedenceGroup : IReadOnlyAssignmentPrecedenceGroup,
    IPrecedenceGroupAttribute
{
    new ILiteral AssignmentValue { get; }

    void ChangeAssignmentValue(ILiteral newAssignmentValue);

    void MakeTrue();

    void MakeFalse();

    void Invert();
}
