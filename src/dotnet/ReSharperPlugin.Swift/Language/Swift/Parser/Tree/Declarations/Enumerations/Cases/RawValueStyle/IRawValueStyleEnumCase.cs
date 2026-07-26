using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;
using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Identifiers;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Enumerations.Cases.RawValue;

public interface IRawValueStyleEnumCase : IReadOnlyRawValueStyleEnumCase
{
    new IIdentifier Name { get; }
    
    new ILiteral? Literal { get; }

    void ChangeName(IIdentifier newName);

    void ChangeLiteral(ILiteral newLiteral);
}
