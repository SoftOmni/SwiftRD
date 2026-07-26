using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.PrecedenceGroups.Assignment;

public class PrecedenceAssignmentGroup : SwiftCompositeNode, IPrecedenceAssignmentGroup
{
    public Assignment AssignmentKeyword { get; }

    public Colon AssignmentValueIntroducer { get; }

    public ILiteral AssignmentValue { get; }

    internal PrecedenceAssignmentGroup(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        Assignment assignmentKeyword, Colon assignmentValueIntroducer, ILiteral assignmentValue)
        : base(buffer, children)
    {
        AssignmentKeyword = assignmentKeyword;
        AssignmentValueIntroducer = assignmentValueIntroducer;
        AssignmentValue = assignmentValue;
    }

    IReadOnlyLiteral IReadOnlyPrecedenceAssignmentGroup.AssignmentValue => AssignmentValue;

    public void ChangeAssignmentValue(ILiteral newAssignmentValue)
    {
        throw new System.NotImplementedException();
    }

    public void MakeTrue()
    {
        throw new System.NotImplementedException();
    }

    public void MakeFalse()
    {
        throw new System.NotImplementedException();
    }

    public void Invert()
    {
        throw new System.NotImplementedException();
    }
}
