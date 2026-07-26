using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Expressions.PostfixExpressions.PrimaryExpressions.Literals;

namespace SoftOmni.SwiftRd.Rider.Language.Swift.Parser.Tree.Generics.WhereClauses.Requirements;

public interface ILiteralSameTypeRequirement :
    IReadOnlyLiteralSameTypeRequirement,
    ISameTypeRequirement
{
    new ILiteral Literal { get; }

    void ChangeLiteral(ILiteral newLiteral);
}
