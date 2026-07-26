using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LabeledStatements;

public interface ILabeledStatement : IReadOnlyLabeledStatement, IStatement
{
    new IIdentifier Label { get; }

    void ChangeLabel(IIdentifier newLabel);
}
