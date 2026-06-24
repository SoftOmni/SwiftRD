namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;

public interface IMetaType : IReadOnlyMetaType, IType
{
    new IType Type { get; }

    void ChangeType(IType type);
}
