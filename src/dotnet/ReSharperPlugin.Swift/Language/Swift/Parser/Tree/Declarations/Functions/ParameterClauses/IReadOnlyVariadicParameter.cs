using SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Punctuators;

namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Declarations.Functions.ParameterClauses;

public interface IReadOnlyVariadicParameter : IReadOnlyParameter
{
    Ellipsis Ellipsis { get; }
}
