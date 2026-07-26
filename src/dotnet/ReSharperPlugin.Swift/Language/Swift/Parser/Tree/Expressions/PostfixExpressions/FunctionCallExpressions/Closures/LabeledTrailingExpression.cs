using System;
using System.Collections.Generic;
using JetBrains.Text;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Implementations.InternalNodes;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Base.Interfaces.Root;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.FunctionCallExpressions.Closures;

public class LabeledTrailingExpression : SwiftCompositeNode, ILabeledTrailingExpression
{
    public IIdentifier Label { get; }

    public Colon Colon { get; }

    public IClosureExpression LabeledTrailingClosureExpression { get; }

    internal LabeledTrailingExpression(IEditableBuffer buffer, IEnumerable<ISwiftNode<SwiftCompositeNode>> children,
        IIdentifier identifier, Colon colon, IClosureExpression labeledTrailingClosureExpression)
        : base(buffer, children)
    {
        Label = identifier;
        Colon = colon;
        LabeledTrailingClosureExpression = labeledTrailingClosureExpression;
    }

    IReadOnlyIdentifier IReadOnlyLabeledTrailingExpression.Label => Label;

    IReadOnlyClosureExpression IReadOnlyLabeledTrailingExpression.LabeledTrailingClosureExpression => LabeledTrailingClosureExpression;

    public void ChangeLabel(IIdentifier newIdentifier)
    {
        throw new NotImplementedException();
    }

    public void ChangeLabeledTrailingClosure(IClosureExpression newClosure)
    {
        throw new NotImplementedException();
    }
}
