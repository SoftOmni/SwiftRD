namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.OpaqueTypes;

public interface IOpaqueType : IReadOnlyOpaqueType, IType
{
    new IType Type { get; }
    
    void ChangeType(IType type);
}
