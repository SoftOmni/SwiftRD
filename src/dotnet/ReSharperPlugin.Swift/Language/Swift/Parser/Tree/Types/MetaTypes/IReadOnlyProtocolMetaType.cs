namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.MetaTypes;

public interface IReadOnlyProtocolMetaType : IReadOnlyMetaType
{
    ProtocolUppercase ProtocolKeyword { get; }
}
