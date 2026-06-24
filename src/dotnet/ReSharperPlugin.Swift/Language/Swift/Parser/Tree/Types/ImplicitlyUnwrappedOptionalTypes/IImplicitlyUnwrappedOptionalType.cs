namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.ImplicitlyUnwrappedOptionalType;

public interface IImplicitlyUnwrappedOptionalType : IReadOnlyImplicitlyUnwrappedOptionalType, IType
{
    new IType Type { get; }

    void ChangeType(IType type);
}
