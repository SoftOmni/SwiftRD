namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses.ParameterModifiers;

public interface IReadOnlyConsumingParameterModifier : IReadOnlyParameterModifier
{
    Consuming Keyword { get; }
}