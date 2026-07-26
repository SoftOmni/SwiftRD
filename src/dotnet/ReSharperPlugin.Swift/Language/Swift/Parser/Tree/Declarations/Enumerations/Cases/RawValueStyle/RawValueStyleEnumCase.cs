using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.RawValue;

public class RawValueStyleEnumCase : SwiftCompositeNode, IRawValueStyleEnumCase
{
    public IIdentifier Name { get; }

    public Equal? AssignmentOperator { get; }

    public ILiteral? Literal { get; }

    internal RawValueStyleEnumCase(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier name)
        : base(buffer, children)
    {
        Name = name;
    }

    internal RawValueStyleEnumCase(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier name, Equal assignmentOperator, ILiteral literal)
        : base(buffer, children)
    {
        Name = name;
        AssignmentOperator = assignmentOperator;
        Literal = literal;
    }

    IReadOnlyIdentifier IReadOnlyRawValueStyleEnumCase.Name => Name;

    IReadOnlyLiteral? IReadOnlyRawValueStyleEnumCase.Literal => Literal;

    public void ChangeName(IIdentifier newName)
    {
        throw new NotImplementedException();
    }

    public void ChangeLiteral(ILiteral newLiteral)
    {
        throw new NotImplementedException();
    }
}
