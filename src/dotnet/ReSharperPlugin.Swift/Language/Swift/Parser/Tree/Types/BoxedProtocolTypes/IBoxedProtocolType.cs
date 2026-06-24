namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.BoxedProtocolTypes;

public interface IBoxedProtocolType : IReadOnlyBoxedProtocolType, IType
{
    new IType ConstraintType { get; }

    void ChangeConstraintType(IType type);
}
