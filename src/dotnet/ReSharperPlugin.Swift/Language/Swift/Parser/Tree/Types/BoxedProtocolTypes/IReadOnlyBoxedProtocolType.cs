namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.BoxedProtocolTypes;

public interface IReadOnlyBoxedProtocolType : IReadOnlyType
{
    AnyLowercase Any { get; }
    
    IReadOnlyType ConstraintType { get; }
}
