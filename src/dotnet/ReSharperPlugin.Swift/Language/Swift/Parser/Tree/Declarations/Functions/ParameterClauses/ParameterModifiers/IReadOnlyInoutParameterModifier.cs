namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public interface IReadOnlyInoutParameterModifier : IReadOnlyParameterModifier
{
    InOut Keyword { get; }
}