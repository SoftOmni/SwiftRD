namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.FunctionTypes.Arguments;

public interface ISimpleFunctionTypeArgument : IReadOnlySimpleFunctionTypeArgument, IFunctionTypeArgument
{
    new IType Type { get; }

    void ChangeType(IType newType);
}
