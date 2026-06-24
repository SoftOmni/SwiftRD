namespace SoftOmni.SwiftRd.Language.Swift.Parser.Tree.Types.OptionalTypes;

public interface IOptionalType : IReadOnlyOptionalType, IType
{
    new IType Type { get; }
    
    void ChangeType(IType type);
}
