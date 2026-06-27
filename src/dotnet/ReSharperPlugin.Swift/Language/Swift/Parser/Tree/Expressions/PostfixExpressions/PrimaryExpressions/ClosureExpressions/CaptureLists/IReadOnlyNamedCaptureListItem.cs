using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.ClosureExpressions.CaptureLists;

public interface IReadOnlyNamedCaptureListItem : IReadOnlyCaptureListItem
{
    IReadOnlyIdentifier Name { get; }
    
    Equal? Equal { get; }
    
    IReadOnlyExpression? DefaultValueExpression { get; }
    
    bool HasDefaultValue { get; }
}
