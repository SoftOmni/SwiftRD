namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.OpaqueTypes;

public interface IReadOnlyOpaqueType : IReadOnlyType
{
    Some Some { get; }
    
    IReadOnlyType Type { get; }
}
