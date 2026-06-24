namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.Arguments;

public interface IReadOnlySimpleFunctionTypeArgument : IReadOnlyFunctionTypeArgument
{
    IReadOnlyType Type { get; }
}
