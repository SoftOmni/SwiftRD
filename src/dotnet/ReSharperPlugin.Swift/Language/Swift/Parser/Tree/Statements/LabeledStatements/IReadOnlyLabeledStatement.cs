using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Statements.LabeledStatements;

public interface IReadOnlyLabeledStatement : IReadOnlyStatement
{
    IReadOnlyIdentifier Label { get; }
    
    Colon LabelSeparator { get; }
}
